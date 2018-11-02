using ParkingManagementSystem.DAL;
using ParkingManagementSystem.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManagementSystem.BLL
{
    public class ParkingManagementBLL
    {
        public void DefineSubscriberInfo(SubscriberInfo subscriberInfo)
        {
            ParkingManagementDAL parkingManagementDAL = new ParkingManagementDAL();
            parkingManagementDAL.DefineSubscriberInfo(subscriberInfo);
        }
    }
}
