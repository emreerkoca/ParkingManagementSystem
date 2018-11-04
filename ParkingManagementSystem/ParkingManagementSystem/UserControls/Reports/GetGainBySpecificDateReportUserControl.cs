using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ParkingManagementSystem.BLL;

namespace ParkingManagementSystem.UserControls.Reports
{
    public partial class GetGainBySpecificDateReportUserControl : UserControl
    {
        float totalPrice = 0;
        public GetGainBySpecificDateReportUserControl()
        {
            InitializeComponent();
        }

        private void btnViewGainReport_Click(object sender, EventArgs e)
        {
            ParkingManagementBLL parkingManagementBLL = new ParkingManagementBLL();
            totalPrice = parkingManagementBLL.GetGainBySpecificDate(dtPickerBeginDate.Value,dtPickerEndDate.Value);
            printPreviewDialogGain.ShowDialog();
        }

        private void printDocGain_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //This part sets up the data to be printed
            Graphics g = e.Graphics;
            SolidBrush Brush = new SolidBrush(Color.Black);
            Pen blackPen = new Pen(Color.Black, 3);

            //gets the text from the textbox
            string header = "Belirli Bir Tarihe Göre Kazanç";
            g.DrawString(header, new Font("arial", 16, FontStyle.Bold), Brush, 200, 10);

            g.DrawString("Toplam Kazanç", new Font("arial", 14, FontStyle.Bold), Brush, 30, 50);
            g.DrawString("Başlangıç Tarihi", new Font("arial", 14, FontStyle.Bold), Brush, 180, 50);
            g.DrawString("Bitiş Tarihi", new Font("arial", 14, FontStyle.Bold), Brush, 340, 50);
           
            g.DrawLine(blackPen, new Point(30, 80), new Point(450, 80));


            g.DrawString(totalPrice.ToString(), new Font("arial", 14, FontStyle.Bold), Brush, 30, 90);
            g.DrawString(dtPickerBeginDate.Value.ToShortDateString(), new Font("arial", 14, FontStyle.Bold), Brush, 180, 90);
            g.DrawString(dtPickerEndDate.Value.ToShortDateString(), new Font("arial", 14, FontStyle.Bold), Brush, 340, 90);
            
        }
    }
}
