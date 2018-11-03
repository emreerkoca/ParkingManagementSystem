using ParkingManagementSystem.BLL;
using ParkingManagementSystem.Helpers;
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
    public partial class CarParkingOutForm : Form
    {
        #region Fields
        ParkingManagementBLL parkingManagementBLL = new ParkingManagementBLL();
        CarParkingInfo carParkingInfo = new CarParkingInfo();
        public int locationInfo;
        private float totalPrice;
        private float stayTime;
        #endregion
        public CarParkingOutForm()
        {
            InitializeComponent();

            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                Log.AddExceptionLog(ex);
                MessageBox.Show("Araç çıkışı yapılırken bir sorun oluştu!");
            }
        }

        public void GetCarParkingInfo(int locationInfo)
        {
            carParkingInfo = parkingManagementBLL.GetCarParkingInfo(locationInfo);
        }

        private void dtPickerOutDate_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan timeDifferent = dtPickerOutDate.Value - dtPickerEntryDate.Value;
            stayTime = (float)timeDifferent.Days + (float)timeDifferent.Hours / 24;
            totalPrice = stayTime * carParkingInfo.SchedulePrice;
            txtTotalPrice.Text = totalPrice.ToString();
        }
    }
}
