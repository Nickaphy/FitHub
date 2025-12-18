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
        //Everyone has participated
        ConnectionString connectionstring = new ConnectionString();

        //Gets the number of bookings for a specific class
        public int GetBookingCountDAL(int classID)
        {
            using var con = new SqlConnection(connectionstring.conn);
            con.Open();
            using var cmd = new SqlCommand("SELECT COUNT(*) FROM ClassMembers WHERE ClassID = @ClassID", con);
            cmd.Parameters.AddWithValue("@ClassID", classID);
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            return count;
        }

        //Books a class for a member
        public void BookingClassDAL(int classID, int memberID)
        {
            using var con = new SqlConnection(connectionstring.conn);
            con.Open();

            string addBookingQuery = "INSERT INTO ClassMembers(ClassID, MemberID) VALUES(@ClassID, @MemberID)";

            using var addBookingCmd = new SqlCommand(addBookingQuery, con);
            addBookingCmd.Parameters.AddWithValue("@ClassID", classID);
            addBookingCmd.Parameters.AddWithValue("@MemberID", memberID);
            addBookingCmd.ExecuteNonQuery();
            con.Close();
        }

        //Checks for double booking of a class for a member
        public int CheckDoubleBookingDAL(int classID, int memberID)
        {
            using var con = new SqlConnection(connectionstring.conn);
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
