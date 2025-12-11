using FitHub._2._BusinessLogicLayer.ENT_OBJ;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitHub
{
   
        public class DalInstructorViewMembers
        {
            string conn = "Server=LAPTOP-KE4SJBN2;DataBase=FitHubDB;" +
               "Trusted_Connection=True;Encrypt=False;TrustServerCertificate=True;";

            public List<InstructorViewMembersDTO> GetInstructorViewMembers(int classID)
            {
                List<InstructorViewMembersDTO> viewMembers = new List<InstructorViewMembersDTO>();
                string sql = "SELECT * FROM Class_Overview WHERE ClassID = @ClassID";
                using (SqlConnection connection = new SqlConnection(conn))
                using (SqlCommand cmd = new SqlCommand(sql, connection))




                {
                    cmd.Parameters.AddWithValue("@ClassID", classID);
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {

                        viewMembers.Add(new InstructorViewMembersDTO
                        {


                            memberID = reader.IsDBNull(8) ? 0 : reader.GetInt32(8),
                            memberName = reader.IsDBNull(9) ? string.Empty : reader.GetString(9),

                            

                        });

                    }

                }
                return viewMembers;
            }
        }
}
