using ParkingManagementSystem.Helpers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManagementSystem.DAL
{
    public class ParkingManagementDAL
    {
        string connetionString = "Data Source=DESKTOP-855R5HL;Initial Catalog=ParkingManagement;Integrated Security=True;";

        public void DefineSubscriberInfo(SubscriberInfo subscriberInfo)
        {
            using (SqlConnection connection = new SqlConnection(connetionString))
            {
                connection.Open();
                string spName = "spDefineSubscriberInfo";
                SqlCommand sqlCommand = new SqlCommand(spName, connection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter[] spParameters = new SqlParameter[]
                {
                     new SqlParameter("@FirstName",subscriberInfo.FirstName),
                     new SqlParameter("@LastName", subscriberInfo.LastName),
                     new SqlParameter("@Address", subscriberInfo.Address),
                     new SqlParameter("@District", subscriberInfo.District),
                     new SqlParameter("@Province", subscriberInfo.Province),
                     new SqlParameter("@PhoneNumber", subscriberInfo.PhoneNumber),
                     new SqlParameter("@RegistrationDate",subscriberInfo.RegistrationDate)
                };

                sqlCommand.Parameters.AddRange(spParameters);
                sqlCommand.ExecuteNonQuery();
            }
        }

        public void DefineSchedule(ScheduleInfo scheduleInfo)
        {
            using (SqlConnection connection = new SqlConnection(connetionString))
            {
                connection.Open();
                string spName = "spDefineSchedule";
                SqlCommand sqlCommand = new SqlCommand(spName, connection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter[] spParameters = new SqlParameter[]
                {
                     new SqlParameter("@ScheduleName",scheduleInfo.ScheduleName),
                     new SqlParameter("@FirstHour", scheduleInfo.FirstHour),
                     new SqlParameter("@LastHour", scheduleInfo.LastHour),
                     new SqlParameter("@Price", scheduleInfo.Price),
                     new SqlParameter("@Active", scheduleInfo.IsActive),
                     new SqlParameter("@RegistrationDate", scheduleInfo.RegistrationDate)

                };

                sqlCommand.Parameters.AddRange(spParameters);
                sqlCommand.ExecuteNonQuery();
            }

        }

        public void InsertSubscription(Subscription subscription)
        {
            using (SqlConnection connection = new SqlConnection(connetionString))
            {
                connection.Open();
                string spName = "spInsertSubscription";
                SqlCommand sqlCommand = new SqlCommand(spName, connection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter[] spParameters = new SqlParameter[]
                {
                    new SqlParameter("@SubscriberID",subscription.SubscriberID),
                    new SqlParameter("@BeginDate",subscription.BeginDate),
                    new SqlParameter("@EndDate", subscription.EndDate),
                    new SqlParameter("@SubscriberPrice", subscription.SubscriberPrice),
                    new SqlParameter("@RegistrationDate", subscription.RegistrationDate)
                };

                sqlCommand.Parameters.AddRange(spParameters);
                sqlCommand.ExecuteNonQuery();
            }
        }

        public void InsertCarParkingEntry(CarParkingInfo carParkingInfo)
        {
            using (SqlConnection connection = new SqlConnection(connetionString))
            {
                connection.Open();
                string spName = "spInsertCarParkingEntry";
                SqlCommand sqlCommand = new SqlCommand(spName, connection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter[] spParameters = new SqlParameter[]
                {
                    new SqlParameter("@SubscriberID",carParkingInfo.SubscriberID),
                    new SqlParameter("@ScheduleID", carParkingInfo.ScheduleID),
                    new SqlParameter("@CarPlate",carParkingInfo.CarPlate),
                    new SqlParameter("@EntryDate",carParkingInfo.EntryDate),
                    new SqlParameter("@RegistrationDate",carParkingInfo.RegistrationDate),
                    new SqlParameter("@LocationInfo",carParkingInfo.LocationInfo),
                    new SqlParameter("@IsActive", carParkingInfo.IsActive)
                };

                sqlCommand.Parameters.AddRange(spParameters);
                sqlCommand.ExecuteNonQuery();
            }
        }

        public List<SubscriberInfo> GetSubscriberInfos()
        {
            List<SubscriberInfo> subscriberInfoList = new List<SubscriberInfo>();
            using (SqlConnection connection = new SqlConnection(connetionString))
            {
                connection.Open();
                string spName = "spGetSubscriberInfos";
                SqlCommand sqlCommand = new SqlCommand(spName, connection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                SqlDataReader dr = sqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    subscriberInfoList.Add(
                        new SubscriberInfo
                        {
                            ID = Convert.ToInt32(dr["ABONE_ID"]),
                            FirstName = dr["AD"].ToString(),
                            LastName = dr["SOYAD"].ToString(),
                            Address = dr["ADRES"].ToString(),
                            District = dr["ILCE"].ToString(),
                            Province = dr["IL"].ToString(),
                            PhoneNumber = dr["TELEFON"].ToString(),
                            RegistrationDate = Convert.ToDateTime(dr["KAYIT_TARIHI"])
                        });
                }
            }

            return subscriberInfoList;
        }

        public List<ScheduleInfo> GetSchedules()
        {
            List<ScheduleInfo> scheduleInfoList = new List<ScheduleInfo>();
            using (SqlConnection connection = new SqlConnection(connetionString))
            {
                connection.Open();
                string spName = "spGetSchedules";
                SqlCommand sqlCommand = new SqlCommand(spName, connection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                SqlDataReader dr = sqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    scheduleInfoList.Add(
                        new ScheduleInfo
                        {
                            ID = Convert.ToInt32(dr["ID"]),
                            ScheduleName = dr["TARIFE_ADI"].ToString(),
                            FirstHour = dr["ILK_SAAT"].ToString(),
                            LastHour = dr["SON_SAAT"].ToString(),
                            Price = dr["UCRET"].ToString(),
                            RegistrationDate = Convert.ToDateTime(dr["KAYIT_TARIHI"])
                        });
                }
            }

            return scheduleInfoList;
        }

        public CarParkingInfo GetCarParkingInfo(int locationInfo)
        {
            CarParkingInfo carParkingInfo = new CarParkingInfo();
            using (SqlConnection connection = new SqlConnection(connetionString))
            {
                connection.Open();
                string spName = "spGetCarParkingInfo";
                SqlCommand sqlCommand = new SqlCommand(spName, connection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                sqlCommand.Parameters.Add(new SqlParameter("@LocationInfo", locationInfo));
                SqlDataReader dr = sqlCommand.ExecuteReader();
                if (dr.Read())
                {
                    carParkingInfo.ID = Convert.ToInt32(dr["ID"]);
                    carParkingInfo.EntryDate = Convert.ToDateTime(dr["GIRIS_TARIHI"]);
                    carParkingInfo.SchedulePrice = float.Parse(dr["TARIFE_UCRETI"].ToString());
                }

                return carParkingInfo;
            }

        }

        public List<CarParkingInfo> GetCarParkingInfoListByCarPlate(string carPlate)
        {
            List<CarParkingInfo> carParkingInfo = new List<CarParkingInfo>();

            using (SqlConnection connection = new SqlConnection(connetionString))
            {
                connection.Open();
                string spName = "spGetCarParkingInfoListByCarPlate";
                SqlCommand sqlCommand = new SqlCommand(spName, connection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                sqlCommand.Parameters.Add(new SqlParameter("@CarPlate", carPlate));
                SqlDataReader dr = sqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    carParkingInfo.Add(new CarParkingInfo
                    {
                        ID = Convert.ToInt32(dr["ID"]),
                        SubscriberID = Convert.ToInt32(dr["ABONE_ID"]),
                        CarPlate = dr["ARAC_PLAKA"].ToString(),
                        EntryDate = Convert.ToDateTime(dr["GIRIS_TARIHI"]),
                        OutDate = Convert.ToDateTime(dr["CIKIS_TARIHI"]),
                        StayTime = float.Parse(dr["SURE"].ToString()),
                        TotalPrice = float.Parse(dr["UCRET"].ToString()),
                        ScheduleName = dr["TARIFE_ADI"].ToString(),
                        SchedulePrice = float.Parse(dr["TARIFE_UCRETI"].ToString())
                    });
                }

            }

            return carParkingInfo;
        }

        public List<CarParkingInfo> GetCarParkingInfoListForReport()
        {
            List<CarParkingInfo> carParkingInfoList = new List<CarParkingInfo>();

            using (SqlConnection connection = new SqlConnection(connetionString))
            {
                connection.Open();
                string spName = "spGetCarParkingInfoListForReport";
                SqlCommand sqlCommand = new SqlCommand(spName, connection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                SqlDataReader dr = sqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    carParkingInfoList.Add(new CarParkingInfo
                    {
                        CarPlate = dr["ARAC_PLAKA"].ToString(),
                        LocationInfo = Convert.ToInt32(dr["YER_BILGISI"]),
                        EntryDate = Convert.ToDateTime(dr["GIRIS_TARIHI"].ToString()),
                        ScheduleName = dr["TARIFE_ADI"].ToString(),
                        SubscriberName = dr["ABONE_ADI"].ToString()
                    });
                }
            }

            return carParkingInfoList;
        }

        public List<int> GetLocationInfoList()
        {
            List<int> locationInfoList = new List<int>();
            using (SqlConnection connection = new SqlConnection(connetionString))
            {
                connection.Open();
                string spName = "spGetLocationInfos";
                SqlCommand sqlCommand = new SqlCommand(spName, connection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                SqlDataReader dr = sqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    locationInfoList.Add(Convert.ToInt32(dr["YER_BILGISI"]));
                }
            }

            return locationInfoList;
        }

        public void AddExceptionLog(string exceptionDetail)
        {
            using (SqlConnection connection = new SqlConnection(connetionString))
            {
                connection.Open();
                string spName = "spAddExceptionLog";
                SqlCommand sqlCommand = new SqlCommand(spName, connection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter[] spParameters = new SqlParameter[]
                {
                    new SqlParameter("@LogDetail",exceptionDetail),
                    new SqlParameter("@LogDate", DateTime.Now)
                };

                sqlCommand.Parameters.AddRange(spParameters);
                sqlCommand.ExecuteNonQuery();
            }
        }

        public void ParkingOutGet(CarParkingInfo carParkingInfo)
        {
            using (SqlConnection connection = new SqlConnection(connetionString))
            {
                connection.Open();
                string spName = "spParkingOutGet";
                SqlCommand sqlCommand = new SqlCommand(spName, connection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter[] spParameters = new SqlParameter[]
                {
                    new SqlParameter("@ID",carParkingInfo.ID),
                    new SqlParameter("@OutDate",carParkingInfo.OutDate),
                    new SqlParameter("@StayTime",carParkingInfo.StayTime),
                    new SqlParameter("@TotalPrice", carParkingInfo.TotalPrice),
                    new SqlParameter("@LocationInfo", carParkingInfo.LocationInfo)
                };

                sqlCommand.Parameters.AddRange(spParameters);
                sqlCommand.ExecuteNonQuery();
            }
        }

        public List<SubscriberInfo> GetActiveSubscriberList()
        {
            List<SubscriberInfo> subscriberInfoList = new List<SubscriberInfo>();
            using (SqlConnection connection = new SqlConnection(connetionString))
            {
                connection.Open();
                string spName = "spGetActiveSubscriberList";
                SqlCommand sqlCommand = new SqlCommand(spName, connection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                SqlDataReader dr = sqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    subscriberInfoList.Add(new SubscriberInfo
                    {
                        FirstName = dr["AD"].ToString(),
                        LastName = dr["SOYAD"].ToString(),
                        District = dr["ILCE"].ToString(),
                        Province = dr["IL"].ToString(),
                        PhoneNumber = dr["TELEFON"].ToString(),
                        BeginDate = Convert.ToDateTime(dr["BASLANGIC_TARIHI"].ToString())
                    });
                }
            }

            return subscriberInfoList;
        }

        public float GetGainBySpecificDate(DateTime beginDate, DateTime endDate)
        {
            float totalPrice = 0;
            using (SqlConnection connection = new SqlConnection(connetionString))
            {
                connection.Open();
                string spName = "spGetGainBySpecificDate";
                SqlCommand sqlCommand = new SqlCommand(spName, connection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter[] spParameters = new SqlParameter[]
                {
                    new SqlParameter("@BeginDate", beginDate),
                    new SqlParameter("@EndDate", endDate)
                };

                sqlCommand.Parameters.AddRange(spParameters);
                SqlDataReader dr = sqlCommand.ExecuteReader();
                if(dr.Read())
                {
                    totalPrice = float.Parse(dr["TOPLAM_UCRET"].ToString());
                }
            }

            return totalPrice;
        }
    }
}
