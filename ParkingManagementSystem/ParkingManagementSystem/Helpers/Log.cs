using ParkingManagementSystem.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManagementSystem.Helpers
{
    public class Log
    {
        public static void AddExceptionLog(Exception ex)
        {
            ParkingManagementBLL parkingManagementBLL = new ParkingManagementBLL();
            parkingManagementBLL.AddExceptionLog(ex.ToString());
            parkingManagementBLL = null;
        }
    }
}
