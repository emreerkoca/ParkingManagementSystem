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

namespace ParkingManagementSystem.UserControls
{
    public partial class DefineScheduleUserControl : UserControl
    {
        public DefineScheduleUserControl()
        {
            InitializeComponent();

            dtPickerFirstHour.Format = DateTimePickerFormat.Custom;
            dtPickerFirstHour.CustomFormat = "HH:mm:ss tt";
            dtPickerFirstHour.ShowUpDown = true;

            dtPickerLastHour.Format = DateTimePickerFormat.Custom;
            dtPickerLastHour.CustomFormat = "HH:mm:ss tt";
            dtPickerLastHour.ShowUpDown = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ScheduleInfo scheduleInfo = new ScheduleInfo();
                scheduleInfo.ScheduleName = txtScheduleName.Text;
                scheduleInfo.FirstHour = dtPickerFirstHour.Text;
                scheduleInfo.LastHour = dtPickerLastHour.Text;
                scheduleInfo.Price = txtPrice.Text;
                scheduleInfo.RegistrationDate = DateTime.Now;
                scheduleInfo.IsActive = 1;

                ParkingManagementBLL parkingManagementBLL = new ParkingManagementBLL();
                parkingManagementBLL.DefineSchedule(scheduleInfo);
                MessageBox.Show("Tarife eklendi!");
            }
            catch (Exception ex)
            {
                Log.AddExceptionLog(ex);
            }
        }
    }
}
