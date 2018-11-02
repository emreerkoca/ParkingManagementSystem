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
    public partial class DefinitionSubscriberInfo : UserControl
    {
        public DefinitionSubscriberInfo()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SubscriberInfo subscriberInfo = new SubscriberInfo();
            subscriberInfo.FirstName = txtFirstName.Text;
            subscriberInfo.LastName = txtLastName.Text;
            subscriberInfo.Address = txtAddress.Text;
            subscriberInfo.District = txtDistrict.Text;
            subscriberInfo.Province = txtProvince.Text;
            subscriberInfo.PhoneNumber = txtPhoneNumber.Text;
            subscriberInfo.RegistrationDate = dtPickerRegistrationDate.Value;

            ParkingManagementBLL parkingManagementBLL = new ParkingManagementBLL();
            parkingManagementBLL.DefineSubscriberInfo(subscriberInfo);

            MessageBox.Show("Kayıt başarılı!");
            foreach (Control control in this.Controls)
            {
                if(control is TextBox)
                {
                    ((TextBox)control).Text = string.Empty;
                }
                else if(control is DateTimePicker)
                {
                    ((DateTimePicker)control).Value = DateTime.Now; 
                }
            }
        }
    }
}
