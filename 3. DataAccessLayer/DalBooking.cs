using FitHub._2._BusinessLogicLayer;
using FitHub._2._BusinessLogicLayer.ENT_OBJ;
using FitHub._3._DataAccessLayer;
using FitHub.B_BLL.ENT_OBJ;
using FitHub.C_DAL;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FitHub._3._DataAccessLayer
{
    public class DalBooking
    {
        string conn = "Server=NICKLAS;DataBase=FitHubDB;" +
           "Trusted_Connection=True;Encrypt=False;TrustServerCertificate=True;";
        public void BookingClassDAL(int classID, int memberID)
        {
            using var con = new SqlConnection(conn);
            con.Open();

            string addBookingQuery = "INSERT INTO ClassMembers(ClassID, MemberID) VALUES(@ClassID, @MemberID)";

            using var addBookingCmd = new SqlCommand(addBookingQuery, con);
            addBookingCmd.Parameters.AddWithValue("@ClassID", classID);
            addBookingCmd.Parameters.AddWithValue("@MemberID", memberID);
            addBookingCmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
