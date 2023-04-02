namespace D2DCloneStatus
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.olvData = new BrightIdeasSoftware.ObjectListView();
            this.olvcRegion = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvcProgress = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvcLadder = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvcHC = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvcLastReport = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.lblLastUpdate = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnStartAutoRefresh = new System.Windows.Forms.Button();
            this.btnStopAutoRefresh = new System.Windows.Forms.Button();
            this.nudTimerInterval = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNextRefreshIn = new System.Windows.Forms.Label();
            this.lblAutoRefreshStatus = new System.Windows.Forms.Label();
            this.panelAutoRefreshStatus = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.cbMinimizeToTray = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbFilterHCSC = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbFilterLadderNonLadder = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbFilterRegion = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.olvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimerInterval)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // olvData
            // 
            this.olvData.AllColumns.Add(this.olvcRegion);
            this.olvData.AllColumns.Add(this.olvcProgress);
            this.olvData.AllColumns.Add(this.olvcLadder);
            this.olvData.AllColumns.Add(this.olvcHC);
            this.olvData.AllColumns.Add(this.olvcLastReport);
            this.olvData.AllowColumnReorder = true;
            this.olvData.CellEditUseWholeCell = false;
            this.olvData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvcRegion,
            this.olvcProgress,
            this.olvcLadder,
            this.olvcHC,
            this.olvcLastReport});
            this.olvData.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvData.FullRowSelect = true;
            this.olvData.HideSelection = false;
            this.olvData.Location = new System.Drawing.Point(12, 12);
            this.olvData.Name = "olvData";
            this.olvData.Size = new System.Drawing.Size(496, 426);
            this.olvData.TabIndex = 1;
            this.olvData.UseCompatibleStateImageBehavior = false;
            this.olvData.View = System.Windows.Forms.View.Details;
            // 
            // olvcRegion
            // 
            this.olvcRegion.AspectName = "region";
            this.olvcRegion.Text = "Region";
            this.olvcRegion.Width = 71;
            // 
            // olvcProgress
            // 
            this.olvcProgress.AspectName = "progress";
            this.olvcProgress.Text = "Progress";
            // 
            // olvcLadder
            // 
            this.olvcLadder.AspectName = "ladder";
            this.olvcLadder.Text = "Ladder/Non-Ladder";
            this.olvcLadder.Width = 110;
            // 
            // olvcHC
            // 
            this.olvcHC.AspectName = "hc";
            this.olvcHC.Text = "Hardcore/Softcore";
            this.olvcHC.Width = 108;
            // 
            // olvcLastReport
            // 
            this.olvcLastReport.AspectName = "lastReport";
            this.olvcLastReport.Text = "Last Report";
            this.olvcLastReport.Width = 141;
            // 
            // lblLastUpdate
            // 
            this.lblLastUpdate.AutoSize = true;
            this.lblLastUpdate.Location = new System.Drawing.Point(601, 12);
            this.lblLastUpdate.Name = "lblLastUpdate";
            this.lblLastUpdate.Size = new System.Drawing.Size(66, 13);
            this.lblLastUpdate.TabIndex = 2;
            this.lblLastUpdate.Text = "Last update:";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(604, 52);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnStartAutoRefresh
            // 
            this.btnStartAutoRefresh.Location = new System.Drawing.Point(6, 88);
            this.btnStartAutoRefresh.Name = "btnStartAutoRefresh";
            this.btnStartAutoRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnStartAutoRefresh.TabIndex = 5;
            this.btnStartAutoRefresh.Text = "Start";
            this.btnStartAutoRefresh.UseVisualStyleBackColor = true;
            this.btnStartAutoRefresh.Click += new System.EventHandler(this.btnStartAutoRefresh_Click);
            // 
            // btnStopAutoRefresh
            // 
            this.btnStopAutoRefresh.Location = new System.Drawing.Point(173, 88);
            this.btnStopAutoRefresh.Name = "btnStopAutoRefresh";
            this.btnStopAutoRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnStopAutoRefresh.TabIndex = 6;
            this.btnStopAutoRefresh.Text = "Stop";
            this.btnStopAutoRefresh.UseVisualStyleBackColor = true;
            this.btnStopAutoRefresh.Click += new System.EventHandler(this.btnStopAutoRefresh_Click);
            // 
            // nudTimerInterval
            // 
            this.nudTimerInterval.Location = new System.Drawing.Point(190, 45);
            this.nudTimerInterval.Maximum = new decimal(new int[] {
            900,
            0,
            0,
            0});
            this.nudTimerInterval.Name = "nudTimerInterval";
            this.nudTimerInterval.Size = new System.Drawing.Size(58, 20);
            this.nudTimerInterval.TabIndex = 7;
            this.nudTimerInterval.ValueChanged += new System.EventHandler(this.nudTimerInterval_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblNextRefreshIn);
            this.groupBox1.Controls.Add(this.lblAutoRefreshStatus);
            this.groupBox1.Controls.Add(this.panelAutoRefreshStatus);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nudTimerInterval);
            this.groupBox1.Controls.Add(this.btnStopAutoRefresh);
            this.groupBox1.Controls.Add(this.btnStartAutoRefresh);
            this.groupBox1.Location = new System.Drawing.Point(514, 233);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 117);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Auto refresh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "sec";
            // 
            // lblNextRefreshIn
            // 
            this.lblNextRefreshIn.AutoSize = true;
            this.lblNextRefreshIn.Location = new System.Drawing.Point(65, 45);
            this.lblNextRefreshIn.Name = "lblNextRefreshIn";
            this.lblNextRefreshIn.Size = new System.Drawing.Size(110, 13);
            this.lblNextRefreshIn.TabIndex = 11;
            this.lblNextRefreshIn.Text = "Next refresh in: 10/90";
            // 
            // lblAutoRefreshStatus
            // 
            this.lblAutoRefreshStatus.AutoSize = true;
            this.lblAutoRefreshStatus.Location = new System.Drawing.Point(6, 23);
            this.lblAutoRefreshStatus.Name = "lblAutoRefreshStatus";
            this.lblAutoRefreshStatus.Size = new System.Drawing.Size(47, 13);
            this.lblAutoRefreshStatus.TabIndex = 10;
            this.lblAutoRefreshStatus.Text = "Running";
            // 
            // panelAutoRefreshStatus
            // 
            this.panelAutoRefreshStatus.Location = new System.Drawing.Point(9, 45);
            this.panelAutoRefreshStatus.Name = "panelAutoRefreshStatus";
            this.panelAutoRefreshStatus.Size = new System.Drawing.Size(40, 20);
            this.panelAutoRefreshStatus.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Refresh interval";
            // 
            // trayIcon
            // 
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Text = "D2 dclone status trackeris minimized to tray yo!";
            this.trayIcon.Visible = true;
            this.trayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.trayIcon_MouseDoubleClick);
            // 
            // cbMinimizeToTray
            // 
            this.cbMinimizeToTray.AutoSize = true;
            this.cbMinimizeToTray.Location = new System.Drawing.Point(684, 421);
            this.cbMinimizeToTray.Name = "cbMinimizeToTray";
            this.cbMinimizeToTray.Size = new System.Drawing.Size(98, 17);
            this.cbMinimizeToTray.TabIndex = 9;
            this.cbMinimizeToTray.Text = "Minimize to tray";
            this.cbMinimizeToTray.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cbFilterHCSC);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cbFilterLadderNonLadder);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cbFilterRegion);
            this.groupBox2.Location = new System.Drawing.Point(514, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(274, 132);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filters";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Hardcore/Softcore";
            // 
            // cbFilterHCSC
            // 
            this.cbFilterHCSC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterHCSC.FormattingEnabled = true;
            this.cbFilterHCSC.Location = new System.Drawing.Point(6, 95);
            this.cbFilterHCSC.Name = "cbFilterHCSC";
            this.cbFilterHCSC.Size = new System.Drawing.Size(121, 21);
            this.cbFilterHCSC.TabIndex = 4;
            this.cbFilterHCSC.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(158, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ladder/Non-Ladder";
            // 
            // cbFilterLadderNonLadder
            // 
            this.cbFilterLadderNonLadder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterLadderNonLadder.FormattingEnabled = true;
            this.cbFilterLadderNonLadder.Location = new System.Drawing.Point(147, 42);
            this.cbFilterLadderNonLadder.Name = "cbFilterLadderNonLadder";
            this.cbFilterLadderNonLadder.Size = new System.Drawing.Size(121, 21);
            this.cbFilterLadderNonLadder.TabIndex = 2;
            this.cbFilterLadderNonLadder.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Region";
            // 
            // cbFilterRegion
            // 
            this.cbFilterRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterRegion.FormattingEnabled = true;
            this.cbFilterRegion.Location = new System.Drawing.Point(6, 42);
            this.cbFilterRegion.Name = "cbFilterRegion";
            this.cbFilterRegion.Size = new System.Drawing.Size(121, 21);
            this.cbFilterRegion.TabIndex = 0;
            this.cbFilterRegion.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cbMinimizeToTray);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblLastUpdate);
            this.Controls.Add(this.olvData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diablo 2 Ressurected - Diablo Clone Status";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.olvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimerInterval)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView olvData;
        private BrightIdeasSoftware.OLVColumn olvcRegion;
        private BrightIdeasSoftware.OLVColumn olvcProgress;
        private BrightIdeasSoftware.OLVColumn olvcLadder;
        private BrightIdeasSoftware.OLVColumn olvcHC;
        private BrightIdeasSoftware.OLVColumn olvcLastReport;
        private System.Windows.Forms.Label lblLastUpdate;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnStartAutoRefresh;
        private System.Windows.Forms.Button btnStopAutoRefresh;
        private System.Windows.Forms.NumericUpDown nudTimerInterval;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAutoRefreshStatus;
        private System.Windows.Forms.Panel panelAutoRefreshStatus;
        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.CheckBox cbMinimizeToTray;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNextRefreshIn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbFilterHCSC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbFilterLadderNonLadder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbFilterRegion;
    }
}

