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

                SqlParameter[] spParamaters = new SqlParameter[]
                {
                     new SqlParameter("@FirstName",subscriberInfo.FirstName),
                     new SqlParameter("@LastName", subscriberInfo.LastName),
                     new SqlParameter("@Address", subscriberInfo.Address),
                     new SqlParameter("@District", subscriberInfo.District),
                     new SqlParameter("@Province", subscriberInfo.Province),
                     new SqlParameter("@PhoneNumber", subscriberInfo.PhoneNumber),
                     new SqlParameter("@RegistrationDate",subscriberInfo.RegistrationDate)
                };

                sqlCommand.Parameters.AddRange(spParamaters);
                sqlCommand.ExecuteNonQuery();
            }
        }
    }
}
