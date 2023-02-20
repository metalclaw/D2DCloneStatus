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
        public Form1()
        {
            InitializeComponent();
            refreshStatus();
        }

        public async void refreshStatus()
        {
            responseList = await getData();
            updateList(responseList);
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

            if (difference.Days> 0)
            {
                return difference.Days.ToString() + " days ago";
            }
            if (difference.Hours> 0)
            {
                return difference.Hours.ToString() + " hours ago";
            }
            if (difference.Minutes> 0)
            {
                return difference.Minutes.ToString() + " minutes ago";
            }
            
            return difference.Seconds.ToString() + " seconds ago";
        }

       
    }

    public static class Helpers
    {
        public static DateTime UnixTimeStampToDateTime(double unixTimeStamp)
        {
            // Unix timestamp is seconds past epoch
            DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dateTime = dateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return dateTime;
        }
    }

    public class Response
    {
        public int progress { get; set; }
        public int region { get; set; }
        public int ladder { get; set; }
        public int hc { get; set; }
        public int timestamped { get; set; }
        public int reporter_id { get; set; }

        public ResponseForOLV convertForOLV()
        {
            ResponseForOLV response = new ResponseForOLV();

            response.region = ((RegionMapping)region).ToString();
            response.progress = (progress).ToString() + "/6";
            response.ladder = ((LadderMapping)ladder).ToString();
            response.hc = ((HCMapping)hc).ToString();
            response.lastReport = Form1.parseTimestamp(timestamped);

            return response;
        }
    }

    public class ResponseForOLV
    {
        public string region { get; set; }
        public string progress { get; set; }
        public string ladder { get; set; }
        public string hc { get; set; }
        public string lastReport { get; set; }
    }

    enum RegionMapping
    {
        None,
        Americas,
        Europe,
        Asia
    }

    enum LadderMapping
    { 
        None, 
        Ladder, 
        NonLadder
    }

    enum HCMapping
    {
        None,
        Hardcore,
        Softcore
    }
}
