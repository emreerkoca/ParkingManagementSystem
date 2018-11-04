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
    public partial class CarParkingEntryForm : Form
    {
        #region Fields
        List<ScheduleInfo> scheduleInfoList = new List<ScheduleInfo>();
        public int locationInfo;
        #endregion

        public CarParkingEntryForm()
        {
            InitializeComponent();
            #region Get Users and Schedules
            SubscriberInfo subscriberInfo = new SubscriberInfo();
            subscriberInfo.GetSubscriberInfos(cmbBoxUsers);
            GetSchedules(); 
            #endregion
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                CarParkingInfo carParkingInfo = new CarParkingInfo();
                carParkingInfo.SubscriberID = Convert.ToInt32((cmbBoxUsers.SelectedItem as ComboboxItem).Value);
                carParkingInfo.ScheduleID = Convert.ToInt32((cmbBoxSchedules.SelectedItem as ComboboxItem).Value);
                carParkingInfo.CarPlate = txtPlate.Text;
                carParkingInfo.EntryDate = dtPickerEntryDate.Value;
                carParkingInfo.RegistrationDate = DateTime.Now;
                carParkingInfo.LocationInfo = locationInfo;
                carParkingInfo.IsActive = 1;
                ParkingManagementBLL parkingManagementBLL = new ParkingManagementBLL();
                parkingManagementBLL.InsertCarParkingEntry(carParkingInfo);
                MessageBox.Show("Araç girişi yapıldı!");
                this.Close();
            }
            catch (Exception ex)
            {
                Log.AddExceptionLog(ex);
                MessageBox.Show("Araç girişi yapılırken hata oluştu!");
            }

        }

        private void cmbBoxSchedules_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBoxSchedules.SelectedIndex == 0)
            {
                return;
            }
            ScheduleInfo scheduleInfo = scheduleInfoList.Where(x => x.ID == Convert.ToInt32((cmbBoxSchedules.SelectedItem as ComboboxItem).Value)).FirstOrDefault();
            lblPrice.Text = scheduleInfo.Price;
            lblFirstHour.Text = scheduleInfo.FirstHour;
            lblLastHour.Text = scheduleInfo.LastHour;

            grpBoxScheduleInfo.Visible = true;
        }

        #region Methods
        #region GetSchedules
        void GetSchedules()
        {
            ParkingManagementBLL parkingManagementBLL = new ParkingManagementBLL();
            scheduleInfoList = parkingManagementBLL.GetSchedules();

            ComboboxItem firstItem = new ComboboxItem();
            firstItem.Text = "Seçiniz";
            firstItem.Value = 0;
            cmbBoxSchedules.Items.Add(firstItem);

            foreach (ScheduleInfo scheduleInfo in scheduleInfoList)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = scheduleInfo.ScheduleName;
                item.Value = scheduleInfo.ID;

                cmbBoxSchedules.Items.Add(item);
            }

            cmbBoxSchedules.SelectedIndex = 0;
        }
        #endregion
        #endregion
    }
}
