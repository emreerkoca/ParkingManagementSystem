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
        public void AddExceptionLog(string exceptionDetail)
        {
            ParkingManagementDAL parkingManagementDAL = new ParkingManagementDAL();
            parkingManagementDAL.AddExceptionLog(exceptionDetail);
            parkingManagementDAL = null;
        }

        public void DefineSubscriberInfo(SubscriberInfo subscriberInfo)
        {
            ParkingManagementDAL parkingManagementDAL = new ParkingManagementDAL();
            parkingManagementDAL.DefineSubscriberInfo(subscriberInfo);
            parkingManagementDAL = null;
        }

        public void DefineSchedule(ScheduleInfo scheduleInfo)
        {
            ParkingManagementDAL parkingManagementDAL = new ParkingManagementDAL();
            parkingManagementDAL.DefineSchedule(scheduleInfo);
            parkingManagementDAL = null;
        }

        public void InsertSubscription(Subscription subscription)
        {
            ParkingManagementDAL parkingManagementDAL = new ParkingManagementDAL();
            parkingManagementDAL.InsertSubscription(subscription);
            parkingManagementDAL = null;
        }

        public void InsertCarParkingEntry(CarParkingInfo carParkingInfo)
        {
            ParkingManagementDAL parkingManagementDAL = new ParkingManagementDAL();
            parkingManagementDAL.InsertCarParkingEntry(carParkingInfo);
            parkingManagementDAL = null;
        }

        public List<SubscriberInfo> GetSubscriberInfos()
        {
            ParkingManagementDAL parkingManagementDAL = new ParkingManagementDAL();
            return parkingManagementDAL.GetSubscriberInfos();
        }

        public List<ScheduleInfo> GetSchedules()
        {
            ParkingManagementDAL parkingManagementDAL = new ParkingManagementDAL();
            return parkingManagementDAL.GetSchedules();
        }

        public CarParkingInfo GetCarParkingInfo(int locationInfo)
        {
            ParkingManagementDAL parkingManagementDAL = new ParkingManagementDAL();
            return parkingManagementDAL.GetCarParkingInfo(locationInfo);
        }

        public List<int> GetLocationInfoList()
        {
            ParkingManagementDAL parkingManagementDAL = new ParkingManagementDAL();
            return parkingManagementDAL.GetLocationInfoList();
        }
    }
}
