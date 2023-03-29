using BrightIdeasSoftware;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace D2DCloneStatus
{
    public partial class Form1 : Form
    {
        static string endpoint = "https://diablo2.io/dclone_api.php";
        static HttpClient client = new HttpClient();
        private List<Response> responseList = new List<Response>();
        Timer refreshTimer = new Timer();
        private int timerInterval = 90; //in seconds
        private int currentTimerInterval = 0;

        public Form1()
        {
            InitializeComponent();
            refreshStatus();
            
            nudTimerInterval.Value = timerInterval;

            refreshTimer.Interval = 1000;
            refreshTimer.Tick += new EventHandler(timer_Tick);

            stopTimer();

            void timer_Tick(object sender, EventArgs e)
            {
                currentTimerInterval += 1;
                if (currentTimerInterval >= timerInterval)
                {
                    refreshStatus();
                    currentTimerInterval = 0;
                }
                lblNextRefreshIn.Text = "Next refresh in: " + currentTimerInterval.ToString() + "/" + timerInterval.ToString();
            }
        }

        public async void refreshStatus()
        {
            try
            {
                responseList = await getData();
                updateList(responseList);
                lblLastUpdate.Text = "Last update: " + DateTime.Now.ToString("HH:mm:ss");
            } catch(HttpRequestException ex)
            {
                MessageBox.Show("A HTTP error occured when trying to get data from server. Either the server is down or your internet connection is unstable.", "Error");
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private async Task<List<Response>> getData()
        {
            List<Response> list = new List<Response>();

            HttpResponseMessage response = await client.GetAsync(endpoint);
            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();

                if (json != null)
                {
                    list = JsonConvert.DeserializeObject<List<Response>>(json);
                }
            }

            return list;
        }

        private void updateList(List<Response>results)
        {
            olvData.Items.Clear();

            olvData.SetObjects(convertResultsForOLV(results));
        }

        private List<ResponseForOLV> convertResultsForOLV(List<Response> results)
        {
            List<ResponseForOLV> list = new List<ResponseForOLV>();

            foreach (Response result in results)
            {
                list.Add(result.convertForOLV());
            }

            return list;
        }

        public static string parseTimestamp(double timestamp)
        {
            TimeSpan difference = DateTime.Now - Helpers.UnixTimeStampToDateTime(timestamp);

            if (difference.Days > 0)
            {
                return difference.Days.ToString() + " day(s) ago";
            }
            if (difference.Hours > 0)
            {
                return difference.Hours.ToString() + " hour(s) ago";
            }
            if (difference.Minutes > 0)
            {
                return difference.Minutes.ToString() + " minute(s) ago";
            }
            
            return difference.Seconds.ToString() + " second(s) ago";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refreshStatus();

            if (refreshTimer.Enabled)
            {
                resetTimer();
            }
        }

        private void btnStartAutoRefresh_Click(object sender, EventArgs e)
        {
            startTimer();
        }

        private void btnStopAutoRefresh_Click(object sender, EventArgs e)
        {
            stopTimer();
        }

        private void nudTimerInterval_ValueChanged(object sender, EventArgs e)
        {
            timerInterval = (int)nudTimerInterval.Value;
            resetTimer();
        }
        private void startTimer()
        {
            refreshTimer.Start();
            lblAutoRefreshStatus.Text = "Running";
            panelAutoRefreshStatus.BackColor = Color.Green;
            currentTimerInterval = 0;
            lblNextRefreshIn.Text = "Next refresh in: 0/" + timerInterval.ToString();
        }

        private void stopTimer()
        {
            refreshTimer.Stop();
            lblAutoRefreshStatus.Text = "Stopped";
            panelAutoRefreshStatus.BackColor = Color.Red;
            lblNextRefreshIn.Text = "";
            currentTimerInterval = 0;
        }

        private void resetTimer()
        {
            stopTimer();
            currentTimerInterval = 0;
            startTimer();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized && cbMinimizeToTray.Checked)
            {
                Hide();
            }
        }

        private void trayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (WindowState == FormWindowState.Minimized && !Visible) {
                Show();
                WindowState = FormWindowState.Normal;
            }
        }
    }
}
