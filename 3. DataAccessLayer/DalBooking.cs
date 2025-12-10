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

        public int GetBookingCountDAL(int classID)
        {
            using var con = new SqlConnection(conn);
            con.Open();
            using var cmd = new SqlCommand("SELECT COUNT(*) FROM ClassMembers WHERE ClassID = @ClassID", con);
            cmd.Parameters.AddWithValue("@ClassID", classID);
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            return count;
        }

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

        public int CheckDoubleBookingDAL(int classID, int memberID)
        {             using var con = new SqlConnection(conn);
            con.Open();
            string checkDoubleBookingQuery = "SELECT COUNT(*) FROM ClassMembers WHERE ClassID = @ClassID AND MemberID = @MemberID";
            using var checkDoubleBookingCmd = new SqlCommand(checkDoubleBookingQuery, con);
            checkDoubleBookingCmd.Parameters.AddWithValue("@ClassID", classID);
            checkDoubleBookingCmd.Parameters.AddWithValue("@MemberID", memberID);
            int count = Convert.ToInt32(checkDoubleBookingCmd.ExecuteScalar());
            con.Close();
            return count;
        }
    }
}
