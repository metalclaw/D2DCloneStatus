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
            this.olvData = new BrightIdeasSoftware.ObjectListView();
            this.olvcRegion = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvcProgress = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvcLadder = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvcHC = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvcLastReport = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            ((System.ComponentModel.ISupportInitialize)(this.olvData)).BeginInit();
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.olvData);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.olvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView olvData;
        private BrightIdeasSoftware.OLVColumn olvcRegion;
        private BrightIdeasSoftware.OLVColumn olvcProgress;
        private BrightIdeasSoftware.OLVColumn olvcLadder;
        private BrightIdeasSoftware.OLVColumn olvcHC;
        private BrightIdeasSoftware.OLVColumn olvcLastReport;
    }
}

