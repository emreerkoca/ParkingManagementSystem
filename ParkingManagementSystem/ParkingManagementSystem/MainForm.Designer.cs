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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tanımlamalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defineSubscriberInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createSubscriptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defineScheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.araçGirişÇıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertParkingEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.araçÇıkışıVeÜcretlendirmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.birPlakayaAitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otoparktakiAraçlarıGösterenRaporToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aktifOlarakAboneliğiDevamEdenAbonelerRaporuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aylıkOtoparkKazançRaporuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMain = new System.Windows.Forms.Panel();
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
            this.insertParkingEntryToolStripMenuItem,
            this.araçÇıkışıVeÜcretlendirmeToolStripMenuItem});
            this.araçGirişÇıkışToolStripMenuItem.Name = "araçGirişÇıkışToolStripMenuItem";
            this.araçGirişÇıkışToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.araçGirişÇıkışToolStripMenuItem.Text = "Araç Giriş/Çıkış";
            // 
            // insertParkingEntryToolStripMenuItem
            // 
            this.insertParkingEntryToolStripMenuItem.Name = "insertParkingEntryToolStripMenuItem";
            this.insertParkingEntryToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.insertParkingEntryToolStripMenuItem.Text = "Araç Girişi Ekle";
            this.insertParkingEntryToolStripMenuItem.Click += new System.EventHandler(this.insertParkingEntryToolStripMenuItem_Click);
            // 
            // araçÇıkışıVeÜcretlendirmeToolStripMenuItem
            // 
            this.araçÇıkışıVeÜcretlendirmeToolStripMenuItem.Name = "araçÇıkışıVeÜcretlendirmeToolStripMenuItem";
            this.araçÇıkışıVeÜcretlendirmeToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.araçÇıkışıVeÜcretlendirmeToolStripMenuItem.Text = "Araç Çıkışı ve Ücretlendirme";
            // 
            // raporlarToolStripMenuItem
            // 
            this.raporlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.birPlakayaAitToolStripMenuItem,
            this.otoparktakiAraçlarıGösterenRaporToolStripMenuItem,
            this.aktifOlarakAboneliğiDevamEdenAbonelerRaporuToolStripMenuItem,
            this.aylıkOtoparkKazançRaporuToolStripMenuItem});
            this.raporlarToolStripMenuItem.Name = "raporlarToolStripMenuItem";
            this.raporlarToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.raporlarToolStripMenuItem.Text = "Raporlar";
            // 
            // birPlakayaAitToolStripMenuItem
            // 
            this.birPlakayaAitToolStripMenuItem.Name = "birPlakayaAitToolStripMenuItem";
            this.birPlakayaAitToolStripMenuItem.Size = new System.Drawing.Size(351, 22);
            this.birPlakayaAitToolStripMenuItem.Text = "Bir Plakaya Ait Giriş Çıkış Hareketleri Raporu";
            // 
            // otoparktakiAraçlarıGösterenRaporToolStripMenuItem
            // 
            this.otoparktakiAraçlarıGösterenRaporToolStripMenuItem.Name = "otoparktakiAraçlarıGösterenRaporToolStripMenuItem";
            this.otoparktakiAraçlarıGösterenRaporToolStripMenuItem.Size = new System.Drawing.Size(351, 22);
            this.otoparktakiAraçlarıGösterenRaporToolStripMenuItem.Text = "Otoparktaki Araçları Gösteren Rapor";
            // 
            // aktifOlarakAboneliğiDevamEdenAbonelerRaporuToolStripMenuItem
            // 
            this.aktifOlarakAboneliğiDevamEdenAbonelerRaporuToolStripMenuItem.Name = "aktifOlarakAboneliğiDevamEdenAbonelerRaporuToolStripMenuItem";
            this.aktifOlarakAboneliğiDevamEdenAbonelerRaporuToolStripMenuItem.Size = new System.Drawing.Size(351, 22);
            this.aktifOlarakAboneliğiDevamEdenAbonelerRaporuToolStripMenuItem.Text = "Aktif Olarak Aboneliği Devam Eden Aboneler Raporu";
            // 
            // aylıkOtoparkKazançRaporuToolStripMenuItem
            // 
            this.aylıkOtoparkKazançRaporuToolStripMenuItem.Name = "aylıkOtoparkKazançRaporuToolStripMenuItem";
            this.aylıkOtoparkKazançRaporuToolStripMenuItem.Size = new System.Drawing.Size(351, 22);
            this.aylıkOtoparkKazançRaporuToolStripMenuItem.Text = "Aylık Otopark Kazanç Raporu";
            // 
            // pnlMain
            // 
            this.pnlMain.Location = new System.Drawing.Point(51, 60);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(666, 552);
            this.pnlMain.TabIndex = 1;
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
        private System.Windows.Forms.ToolStripMenuItem insertParkingEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem araçÇıkışıVeÜcretlendirmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem birPlakayaAitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otoparktakiAraçlarıGösterenRaporToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aktifOlarakAboneliğiDevamEdenAbonelerRaporuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aylıkOtoparkKazançRaporuToolStripMenuItem;
        public System.Windows.Forms.Panel pnlMain;
    }
}

