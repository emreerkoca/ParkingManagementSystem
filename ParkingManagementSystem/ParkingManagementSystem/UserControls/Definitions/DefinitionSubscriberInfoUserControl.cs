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
    public partial class DefinitionSubscriberInfoUserControl : UserControl
    {
        #region Ctor
        public DefinitionSubscriberInfoUserControl()
        {
            InitializeComponent();
        }
        #endregion
        #region Events
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SubscriberInfo subscriberInfo = new SubscriberInfo();
                subscriberInfo.FirstName = txtFirstName.Text;
                subscriberInfo.LastName = txtLastName.Text;
                subscriberInfo.Address = txtAddress.Text;
                subscriberInfo.District = txtDistrict.Text;
                subscriberInfo.Province = txtProvince.Text;
                subscriberInfo.PhoneNumber = txtPhoneNumber.Text;
                subscriberInfo.RegistrationDate = DateTime.Now;

                ParkingManagementBLL parkingManagementBLL = new ParkingManagementBLL();
                parkingManagementBLL.DefineSubscriberInfo(subscriberInfo);

                MessageBox.Show("Kayıt başarılı!");
                ClearPanel();


            }
            catch (Exception ex)
            {
                Log.AddExceptionLog(ex);
                MessageBox.Show("Kayıt eklenemedi!");
            }
        }
        #endregion
        #region Methods
        void ClearPanel()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Text = string.Empty;
                }
            }
        } 
        #endregion
    }
}
