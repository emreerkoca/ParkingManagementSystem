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
using ParkingManagementSystem.Helpers;

namespace ParkingManagementSystem.UserControls
{
    public partial class CreateSubscriptionsUserControl : UserControl
    {
        #region Ctor
        public CreateSubscriptionsUserControl()
        {
            InitializeComponent();

            SubscriberInfo subscriberInfo = new SubscriberInfo();
            subscriberInfo.GetSubscriberInfos(cmbBoxUsers);
        }
        #endregion
        #region Events
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Subscription subscriptions = new Subscription();
                subscriptions.SubscriberID = Convert.ToInt32((cmbBoxUsers.SelectedItem as ComboboxItem).Value);
                subscriptions.BeginDate = dtPickerBeginDate.Value;
                subscriptions.EndDate = dtPickerEndDate.Value;
                subscriptions.SubscriberPrice = 50;
                subscriptions.RegistrationDate = DateTime.Now;
                subscriptions.IsActive = 1;

                ParkingManagementBLL parkingManagementBLL = new ParkingManagementBLL();
                parkingManagementBLL.InsertSubscription(subscriptions);
                MessageBox.Show("Abonelik kaydı tamamlandı!");
            }
            catch (Exception ex)
            {
                Log.AddExceptionLog(ex);
                MessageBox.Show("Abonelik kaydı başarısız!");
            }
        }

        private void cmbBoxSchedules_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        #endregion
    }
}
