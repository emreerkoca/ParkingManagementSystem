using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManagementSystem.Helpers
{
    public class Subscription
    {
        public int ID { get; set; }
        public int SubscriberID { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public float SubscriberPrice { get; set; }
        public DateTime RegistrationDate { get; set; }
    }
}
