using ParkingManagementSystem.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingManagementSystem.Helpers
{
    public class SubscriberInfo
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string District { get; set; }
        public string Province { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime RegistrationDate { get; set; }


        public void GetSubscriberInfos(ComboBox cmbBoxUsers)
        {
            ParkingManagementBLL parkingManagementBLL = new ParkingManagementBLL();
            List<SubscriberInfo> subscriberInfoList = parkingManagementBLL.GetSubscriberInfos();

            ComboboxItem firstItem = new ComboboxItem();
            firstItem.Text = "Seçiniz";
            firstItem.Value = 0;
            cmbBoxUsers.Items.Add(firstItem);

            foreach (SubscriberInfo subscriberInfo in subscriberInfoList)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = subscriberInfo.FirstName + " " + subscriberInfo.LastName;
                item.Value = subscriberInfo.ID;

                cmbBoxUsers.Items.Add(item);
            }
            cmbBoxUsers.SelectedIndex = 0;
        }
    }
}
