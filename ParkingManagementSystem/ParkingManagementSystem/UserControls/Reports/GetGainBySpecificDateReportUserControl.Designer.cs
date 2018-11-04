namespace ParkingManagementSystem.UserControls.Reports
{
    partial class GetGainBySpecificDateReportUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GetGainBySpecificDateReportUserControl));
            this.label1 = new System.Windows.Forms.Label();
            this.dtPickerBeginDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtPickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.btnViewGainReport = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.printPreviewDialogGain = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocGain = new System.Drawing.Printing.PrintDocument();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Başlangıç Tarihi:";
            // 
            // dtPickerBeginDate
            // 
            this.dtPickerBeginDate.Location = new System.Drawing.Point(179, 78);
            this.dtPickerBeginDate.Name = "dtPickerBeginDate";
            this.dtPickerBeginDate.Size = new System.Drawing.Size(200, 20);
            this.dtPickerBeginDate.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bitiş Tarihi:";
            // 
            // dtPickerEndDate
            // 
            this.dtPickerEndDate.Location = new System.Drawing.Point(179, 116);
            this.dtPickerEndDate.Name = "dtPickerEndDate";
            this.dtPickerEndDate.Size = new System.Drawing.Size(200, 20);
            this.dtPickerEndDate.TabIndex = 3;
            // 
            // btnViewGainReport
            // 
            this.btnViewGainReport.Location = new System.Drawing.Point(252, 164);
            this.btnViewGainReport.Name = "btnViewGainReport";
            this.btnViewGainReport.Size = new System.Drawing.Size(127, 23);
            this.btnViewGainReport.TabIndex = 4;
            this.btnViewGainReport.Text = "Raporu Görüntüle";
            this.btnViewGainReport.UseVisualStyleBackColor = true;
            this.btnViewGainReport.Click += new System.EventHandler(this.btnViewGainReport_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(163, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kazanç Raporu";
            // 
            // printPreviewDialogGain
            // 
            this.printPreviewDialogGain.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialogGain.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialogGain.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialogGain.Document = this.printDocGain;
            this.printPreviewDialogGain.Enabled = true;
            this.printPreviewDialogGain.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialogGain.Icon")));
            this.printPreviewDialogGain.Name = "printPreviewDialogGain";
            this.printPreviewDialogGain.Visible = false;
            // 
            // printDocGain
            // 
            this.printDocGain.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocGain_PrintPage);
            // 
            // MonthlyGainReportUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnViewGainReport);
            this.Controls.Add(this.dtPickerEndDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtPickerBeginDate);
            this.Controls.Add(this.label1);
            this.Name = "MonthlyGainReportUserControl";
            this.Size = new System.Drawing.Size(456, 363);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtPickerBeginDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtPickerEndDate;
        private System.Windows.Forms.Button btnViewGainReport;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialogGain;
        private System.Drawing.Printing.PrintDocument printDocGain;
    }
}
