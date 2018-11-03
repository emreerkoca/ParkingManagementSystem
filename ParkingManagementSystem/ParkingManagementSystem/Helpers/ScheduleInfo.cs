using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManagementSystem.Helpers
{
    public class ScheduleInfo
    {
        public int ID { get; set; }
        public string ScheduleName { get; set; }
        public string FirstHour { get; set; }
        public string LastHour { get; set; }
        public string Price { get; set; }
        public int IsActive { get; set; }
        public DateTime RegistrationDate { get; set; }
    }
}
