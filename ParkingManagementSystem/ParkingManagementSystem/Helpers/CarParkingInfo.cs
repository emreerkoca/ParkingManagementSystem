using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManagementSystem.Helpers
{
    public class CarParkingInfo
    {
        public int ID { get; set; }
        public int SubscriberID { get; set; }
        public int ScheduleID { get; set; }
        public string ScheduleName { get; set; }
        public string CarPlate { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime OutDate { get; set; }
        public float StayTime { get; set; }
        public float TotalPrice { get; set; }
        public float SchedulePrice { get; set; }
        public DateTime RegistrationDate { get; set; }
        public int LocationInfo { get; set; }
        public string SubscriberName { get; set; }
        public int IsActive { get; set; }
    }
}
