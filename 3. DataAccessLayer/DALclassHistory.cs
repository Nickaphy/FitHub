using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitHub._2._BusinessLogicLayer.ENT_OBJ;

namespace FitHub._3._DataAccessLayer
{
    public class DalClassHistory
    {
		ConnectionString connectionstring = new ConnectionString();

		public List<ClassHistoryDTO> GetClassHistory(int instructorID)
        {
            List<ClassHistoryDTO> history = new List<ClassHistoryDTO>();
            string sql = "SELECT * FROM Instructor_Overview WHERE InstructorID = @InstructorID";
            using (SqlConnection connection = new SqlConnection(conn))
            using (SqlCommand cmd = new SqlCommand(sql, connection))




            {
                cmd.Parameters.AddWithValue("@InstructorID", instructorID);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    history.Add(new ClassHistoryDTO
                    {


                        classID = reader.IsDBNull(0) ? 0 : reader.GetInt32(0),
                        classDate = reader.IsDBNull(1) ? DateTime.UtcNow : reader.GetDateTime(1),
                        classTime = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                        classLocation = reader.IsDBNull(3) ? string.Empty : reader.GetString(3),
                        classType = reader.IsDBNull(4) ? string.Empty : reader.GetString(4),
                        classCapacity = reader.IsDBNull(5) ? string.Empty : reader.GetString(5),
                        instructorID = reader.IsDBNull(6) ? 0 : reader.GetInt32(6),
                        instructorName = reader.IsDBNull(7) ? string.Empty : reader.GetString(7),
                       


                    });

                }

            }
            return history;
        }
    }
}
