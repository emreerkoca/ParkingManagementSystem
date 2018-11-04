namespace ParkingManagementSystem
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tanımlamalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defineSubscriberInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createSubscriptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defineScheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.araçGirişÇıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parkingAreaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carPlateEntryOutReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carParkingInfoListForReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activeSubscribersReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthlyGainReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.printDocAllCars = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialogAllCars = new System.Windows.Forms.PrintPreviewDialog();
            this.printPreviewDialogActiveSubscribers = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocActiveSubscribers = new System.Drawing.Printing.PrintDocument();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tanımlamalarToolStripMenuItem,
            this.araçGirişÇıkışToolStripMenuItem,
            this.raporlarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tanımlamalarToolStripMenuItem
            // 
            this.tanımlamalarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.defineSubscriberInfoToolStripMenuItem,
            this.createSubscriptionsToolStripMenuItem,
            this.defineScheduleToolStripMenuItem});
            this.tanımlamalarToolStripMenuItem.Name = "tanımlamalarToolStripMenuItem";
            this.tanımlamalarToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.tanımlamalarToolStripMenuItem.Text = "Tanımlamalar";
            // 
            // defineSubscriberInfoToolStripMenuItem
            // 
            this.defineSubscriberInfoToolStripMenuItem.Name = "defineSubscriberInfoToolStripMenuItem";
            this.defineSubscriberInfoToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.defineSubscriberInfoToolStripMenuItem.Text = "Abone Bilgisi Tanımla";
            this.defineSubscriberInfoToolStripMenuItem.Click += new System.EventHandler(this.defineSubscriberInfoToolStripMenuMenuItem_Click);
            // 
            // createSubscriptionsToolStripMenuItem
            // 
            this.createSubscriptionsToolStripMenuItem.Name = "createSubscriptionsToolStripMenuItem";
            this.createSubscriptionsToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.createSubscriptionsToolStripMenuItem.Text = "Abonelik Oluştur";
            this.createSubscriptionsToolStripMenuItem.Click += new System.EventHandler(this.createSubscriptionsToolStripMenuItem_Click);
            // 
            // defineScheduleToolStripMenuItem
            // 
            this.defineScheduleToolStripMenuItem.Name = "defineScheduleToolStripMenuItem";
            this.defineScheduleToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.defineScheduleToolStripMenuItem.Text = "Tarife Tanımla";
            this.defineScheduleToolStripMenuItem.Click += new System.EventHandler(this.defineScheduleToolStripMenuItem_Click);
            // 
            // araçGirişÇıkışToolStripMenuItem
            // 
            this.araçGirişÇıkışToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parkingAreaToolStripMenuItem});
            this.araçGirişÇıkışToolStripMenuItem.Name = "araçGirişÇıkışToolStripMenuItem";
            this.araçGirişÇıkışToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.araçGirişÇıkışToolStripMenuItem.Text = "Araç Giriş/Çıkış";
            // 
            // parkingAreaToolStripMenuItem
            // 
            this.parkingAreaToolStripMenuItem.Name = "parkingAreaToolStripMenuItem";
            this.parkingAreaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.parkingAreaToolStripMenuItem.Text = "Otoparkı Göster";
            this.parkingAreaToolStripMenuItem.Click += new System.EventHandler(this.parkingAreaToolStripMenuItem_Click);
            // 
            // raporlarToolStripMenuItem
            // 
            this.raporlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.carPlateEntryOutReportToolStripMenuItem,
            this.carParkingInfoListForReportToolStripMenuItem,
            this.activeSubscribersReportToolStripMenuItem,
            this.monthlyGainReportToolStripMenuItem});
            this.raporlarToolStripMenuItem.Name = "raporlarToolStripMenuItem";
            this.raporlarToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.raporlarToolStripMenuItem.Text = "Raporlar";
            // 
            // carPlateEntryOutReportToolStripMenuItem
            // 
            this.carPlateEntryOutReportToolStripMenuItem.Name = "carPlateEntryOutReportToolStripMenuItem";
            this.carPlateEntryOutReportToolStripMenuItem.Size = new System.Drawing.Size(351, 22);
            this.carPlateEntryOutReportToolStripMenuItem.Text = "Bir Plakaya Ait Giriş Çıkış Hareketleri Raporu";
            this.carPlateEntryOutReportToolStripMenuItem.Click += new System.EventHandler(this.carPlateEntryOutReportToolStripMenuItem_Click);
            // 
            // carParkingInfoListForReportToolStripMenuItem
            // 
            this.carParkingInfoListForReportToolStripMenuItem.Name = "carParkingInfoListForReportToolStripMenuItem";
            this.carParkingInfoListForReportToolStripMenuItem.Size = new System.Drawing.Size(351, 22);
            this.carParkingInfoListForReportToolStripMenuItem.Text = "Otoparktaki Araçları Gösteren Rapor";
            this.carParkingInfoListForReportToolStripMenuItem.Click += new System.EventHandler(this.carParkingInfoListForReportToolStripMenuItem_Click);
            // 
            // activeSubscribersReportToolStripMenuItem
            // 
            this.activeSubscribersReportToolStripMenuItem.Name = "activeSubscribersReportToolStripMenuItem";
            this.activeSubscribersReportToolStripMenuItem.Size = new System.Drawing.Size(351, 22);
            this.activeSubscribersReportToolStripMenuItem.Text = "Aktif Olarak Aboneliği Devam Eden Aboneler Raporu";
            this.activeSubscribersReportToolStripMenuItem.Click += new System.EventHandler(this.activeSubscribersReportToolStripMenuItem_Click);
            // 
            // monthlyGainReportToolStripMenuItem
            // 
            this.monthlyGainReportToolStripMenuItem.Name = "monthlyGainReportToolStripMenuItem";
            this.monthlyGainReportToolStripMenuItem.Size = new System.Drawing.Size(351, 22);
            this.monthlyGainReportToolStripMenuItem.Text = "Aylık Otopark Kazanç Raporu";
            this.monthlyGainReportToolStripMenuItem.Click += new System.EventHandler(this.monthlyGainReportToolStripMenuItem_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Location = new System.Drawing.Point(51, 60);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(666, 552);
            this.pnlMain.TabIndex = 1;
            // 
            // printDocAllCars
            // 
            this.printDocAllCars.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocAllCars_PrintPage);
            // 
            // printPreviewDialogAllCars
            // 
            this.printPreviewDialogAllCars.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialogAllCars.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialogAllCars.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialogAllCars.Document = this.printDocAllCars;
            this.printPreviewDialogAllCars.Enabled = true;
            this.printPreviewDialogAllCars.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialogAllCars.Icon")));
            this.printPreviewDialogAllCars.Name = "printPreviewDialogAllCars";
            this.printPreviewDialogAllCars.Visible = false;
            // 
            // printPreviewDialogActiveSubscribers
            // 
            this.printPreviewDialogActiveSubscribers.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialogActiveSubscribers.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialogActiveSubscribers.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialogActiveSubscribers.Document = this.printDocActiveSubscribers;
            this.printPreviewDialogActiveSubscribers.Enabled = true;
            this.printPreviewDialogActiveSubscribers.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialogActiveSubscribers.Icon")));
            this.printPreviewDialogActiveSubscribers.Name = "printPreviewDialogActiveSubscribers";
            this.printPreviewDialogActiveSubscribers.Visible = false;
            // 
            // printDocActiveSubscribers
            // 
            this.printDocActiveSubscribers.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocActiveSubscribers_PrintPage);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 628);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Otopark Yönetim Sistemi";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tanımlamalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defineSubscriberInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createSubscriptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defineScheduleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem araçGirişÇıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parkingAreaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carPlateEntryOutReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carParkingInfoListForReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activeSubscribersReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monthlyGainReportToolStripMenuItem;
        public System.Windows.Forms.Panel pnlMain;
        private System.Drawing.Printing.PrintDocument printDocAllCars;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialogAllCars;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialogActiveSubscribers;
        private System.Drawing.Printing.PrintDocument printDocActiveSubscribers;
    }
}

