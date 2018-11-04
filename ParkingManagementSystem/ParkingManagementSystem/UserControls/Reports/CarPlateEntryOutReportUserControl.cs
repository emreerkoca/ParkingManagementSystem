using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ParkingManagementSystem.Helpers;
using ParkingManagementSystem.BLL;

namespace ParkingManagementSystem.UserControls.Reports
{
    public partial class CarPlateEntryOutReportUserControl : UserControl
    {
        List<CarParkingInfo> carParkingInfoList = new List<CarParkingInfo>();

        public CarPlateEntryOutReportUserControl()
        {
            InitializeComponent();
        }

        List<CarParkingInfo> GetCarParkingInfoListByCarPlate(string carPlate)
        {
            try
            {
                ParkingManagementBLL parkingManagementBLL = new ParkingManagementBLL();
                return parkingManagementBLL.GetCarParkingInfoListByCarPlate(carPlate);
            }
            catch (Exception ex)
            {
                Log.AddExceptionLog(ex);
                MessageBox.Show("Rapor çıktısı alırken bir sorun oluştu.");
                return null;
            }
        }

        private void printDocCarPlateEntryOutReport_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int y = 50;
            
            //This part sets up the data to be printed
            Graphics g = e.Graphics;
            SolidBrush Brush = new SolidBrush(Color.Black);
            Pen blackPen = new Pen(Color.Black, 3);

            //gets the text from the textbox
            string header = txtCarPlate.Text + " Plakalı Ait Giriş Çıkış Kayıtları";
            g.DrawString(header, new Font("arial", 16, FontStyle.Bold), Brush, 200, 10);

            g.DrawString("Giris Tarihi", new Font("arial", 14, FontStyle.Bold), Brush, 30, 50);
            g.DrawString("Cikis Tarihi", new Font("arial", 14, FontStyle.Bold), Brush, 150, 50);
            g.DrawString("Tarife", new Font("arial", 14, FontStyle.Bold), Brush, 270, 50);
            g.DrawString("Tarife Ucreti", new Font("arial", 14, FontStyle.Bold), Brush, 350, 50);
            g.DrawString("Sure (Gün)", new Font("arial", 14, FontStyle.Bold), Brush, 470, 50);
            g.DrawString("Toplam Ucret", new Font("arial", 14, FontStyle.Bold), Brush, 590, 50);
            g.DrawLine(blackPen, new Point(30, 80), new Point(710, 80));

            foreach (CarParkingInfo carParkingInfo in carParkingInfoList)
            {
                y += 40;
                g.DrawString(carParkingInfo.EntryDate.ToShortDateString(), new Font("arial", 14, FontStyle.Bold), Brush, 30, y);
                g.DrawString(carParkingInfo.OutDate.ToShortDateString(), new Font("arial", 14, FontStyle.Bold), Brush, 150, y);
                g.DrawString(carParkingInfo.ScheduleName, new Font("arial", 14, FontStyle.Bold), Brush, 270, y);
                g.DrawString(carParkingInfo.SchedulePrice.ToString(), new Font("arial", 14, FontStyle.Bold), Brush, 350, y);
                g.DrawString(carParkingInfo.StayTime.ToString(), new Font("arial", 14, FontStyle.Bold), Brush, 470, y);
                g.DrawString(carParkingInfo.TotalPrice.ToString() + " TL", new Font("arial", 14, FontStyle.Bold), Brush, 590, y);
            }

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            carParkingInfoList = GetCarParkingInfoListByCarPlate(txtCarPlate.Text);
            printPreviewDialog.ShowDialog();
        }
    }
}
