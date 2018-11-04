using ParkingManagementSystem.BLL;
using ParkingManagementSystem.Helpers;
using ParkingManagementSystem.UserControls;
using ParkingManagementSystem.UserControls.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingManagementSystem
{
    public partial class MainForm : Form
    {
        #region Fields
        List<CarParkingInfo> carParkingInfoList = new List<CarParkingInfo>();
        List<SubscriberInfo> subscriberInfoList = new List<SubscriberInfo>();
        #endregion

        #region Ctor
        public MainForm()
        {
            InitializeComponent();
        } 
        #endregion

        #region Events
        private void defineSubscriberInfoToolStripMenuMenuItem_Click(object sender, EventArgs e)
        {
            ClearPanel();
            DefinitionSubscriberInfoUserControl definitionSubscriberInfo = new DefinitionSubscriberInfoUserControl();
            pnlMain.Controls.Add(definitionSubscriberInfo);
        }

        private void createSubscriptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearPanel();
            CreateSubscriptionsUserControl createSubscriptions = new CreateSubscriptionsUserControl();
            pnlMain.Controls.Add(createSubscriptions);

        }

        private void defineScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearPanel();
            DefineScheduleUserControl defineSchedule = new DefineScheduleUserControl();
            pnlMain.Controls.Add(defineSchedule);
        }

        private void parkingAreaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshParkingAreas();
        }
        #endregion

        #region Methods
        void ClearPanel()
        {
            foreach (Control control in pnlMain.Controls)
            {
                control.Dispose();
            }
        }

        public void RefreshParkingAreas()
        {
            ClearPanel();
            CarParkingUserControl carParkingUserControl = new CarParkingUserControl();
            pnlMain.Controls.Add(carParkingUserControl);
        }
        #endregion

        private void carPlateEntryOutReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearPanel();
            CarPlateEntryOutReportUserControl carPlateEntryOutReportUserControl = new CarPlateEntryOutReportUserControl();
            pnlMain.Controls.Add(carPlateEntryOutReportUserControl);
        }

        private void carParkingInfoListForReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ParkingManagementBLL parkingManagementBLL = new ParkingManagementBLL();
            carParkingInfoList = parkingManagementBLL.GetCarParkingInfoListForReport();
            printPreviewDialogAllCars.ShowDialog();
        }

        private void printDocAllCars_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int y = 50;

            //This part sets up the data to be printed
            Graphics g = e.Graphics;
            SolidBrush Brush = new SolidBrush(Color.Black);
            Pen blackPen = new Pen(Color.Black, 3);

            //gets the text from the textbox
            string header = "Otoparktaki Tüm Araçlar";
            g.DrawString(header, new Font("arial", 16, FontStyle.Bold), Brush, 200, 10);

            g.DrawString("Plaka", new Font("arial", 14, FontStyle.Bold), Brush, 30, 50);
            g.DrawString("Yer Bilgisi", new Font("arial", 14, FontStyle.Bold), Brush, 150, 50);
            g.DrawString("Giriş Tarihi", new Font("arial", 14, FontStyle.Bold), Brush, 270, 50);
            g.DrawString("Tarife Adı", new Font("arial", 14, FontStyle.Bold), Brush, 390, 50);
            g.DrawString("Abone Adı", new Font("arial", 14, FontStyle.Bold), Brush, 510, 50);
            g.DrawLine(blackPen, new Point(30, 80), new Point(610, 80));

            foreach (CarParkingInfo carParkingInfo in carParkingInfoList)
            {
                y += 40;
                g.DrawString(carParkingInfo.CarPlate, new Font("arial", 14, FontStyle.Bold), Brush, 30, y);
                g.DrawString( "P - " + carParkingInfo.LocationInfo.ToString(), new Font("arial", 14, FontStyle.Bold), Brush, 150, y);
                g.DrawString(carParkingInfo.EntryDate.ToShortDateString(), new Font("arial", 14, FontStyle.Bold), Brush, 270, y);
                g.DrawString(carParkingInfo.ScheduleName, new Font("arial", 14, FontStyle.Bold), Brush, 390, y);
                g.DrawString(carParkingInfo.SubscriberName, new Font("arial", 14, FontStyle.Bold), Brush, 510, y);
            }
        }

        private void activeSubscribersReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ParkingManagementBLL parkingManagementBLL = new ParkingManagementBLL();
            subscriberInfoList = parkingManagementBLL.GetActiveSubscriberList();
            printPreviewDialogActiveSubscribers.ShowDialog();
        }

        private void printDocActiveSubscribers_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int y = 50;

            //This part sets up the data to be printed
            Graphics g = e.Graphics;
            SolidBrush Brush = new SolidBrush(Color.Black);
            Pen blackPen = new Pen(Color.Black, 3);

            //gets the text from the textbox
            string header = "Aktif Aboneler Raporu";
            g.DrawString(header, new Font("arial", 16, FontStyle.Bold), Brush, 200, 10);

            g.DrawString("Abone", new Font("arial", 14, FontStyle.Bold), Brush, 30, 50);
            g.DrawString("Ilce", new Font("arial", 14, FontStyle.Bold), Brush, 160, 50);
            g.DrawString("Il", new Font("arial", 14, FontStyle.Bold), Brush, 270, 50);
            g.DrawString("Telefon", new Font("arial", 14, FontStyle.Bold), Brush, 390, 50);
            g.DrawString("Baslangic Tarihi", new Font("arial", 14, FontStyle.Bold), Brush, 520, 50);
            g.DrawLine(blackPen, new Point(30, 80), new Point(640, 80));

            foreach (SubscriberInfo subscriberInfo in subscriberInfoList)
            {
                y += 40;
                g.DrawString(subscriberInfo.FirstName + " " + subscriberInfo.LastName, new Font("arial", 14, FontStyle.Bold), Brush, 30, y);
                g.DrawString(subscriberInfo.District, new Font("arial", 14, FontStyle.Bold), Brush, 160, y);
                g.DrawString(subscriberInfo.Province, new Font("arial", 14, FontStyle.Bold), Brush, 270, y);
                g.DrawString(subscriberInfo.PhoneNumber, new Font("arial", 14, FontStyle.Bold), Brush, 390, y);
                g.DrawString(subscriberInfo.BeginDate.ToShortDateString(), new Font("arial", 14, FontStyle.Bold), Brush, 520, y);
            }
        }

        private void monthlyGainReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearPanel();
            GetGainBySpecificDateReportUserControl getGainBySpecificDateReportUserControl = new GetGainBySpecificDateReportUserControl();
            pnlMain.Controls.Add(getGainBySpecificDateReportUserControl);
        }
    }
}
