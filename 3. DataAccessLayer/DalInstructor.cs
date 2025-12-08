using FitHub._2._BusinessLogicLayer.ENT_OBJ;
using FitHub.B_BLL;
using FitHub.B_BLL.ENT_OBJ;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace FitHub._3._DataAccessLayer
{
    internal class DalInstructor
    {
        string conn = "Server=NICKLAS;DataBase=FitHubDB;" +
           "Trusted_Connection=True;Encrypt=False;TrustServerCertificate=True;";
        


        public List<Instructor> GetAllInstructors()
        {
            List<Instructor> instructorList = new List<Instructor>();
            using var con = new SqlConnection(conn);
            con.Open();
            using var cmd = new SqlCommand("SELECT * FROM Instructors", con);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                //add new memebers to memberList (if DB=null, set to default value)
                //else read the vale from the DB.
                instructorList.Add(new Instructor
                {
                    InstructorID = reader.IsDBNull(0) ? 0 : reader.GetInt32(0),
                    FirstName = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                    SurName = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                    Email = reader.IsDBNull(3) ? string.Empty : reader.GetString(3),
                    Telephone = reader.IsDBNull(4) ? string.Empty : reader.GetString(4),
                    Certification = reader.IsDBNull(5) ? string.Empty : reader.GetString(5),
                    
                });
            }
            con.Close();
            return instructorList;
        }
        public void AddInstructor(Instructor instructor)
        {
            BLL bll = new BLL();
            using var con = new SqlConnection(conn);
            con.Open();

            string addInstructorQuery = @"INSERT INTO Instructors (FirstName, SurName, Email, Telephone, Certifications) 
                     VALUES (@FirstName, @SurName, @Email, @Telephone, @Certifications)";

            using var addInsCmd = new SqlCommand(addInstructorQuery, con);
            addInsCmd.Parameters.AddWithValue("@FirstName", instructor.FirstName);
            addInsCmd.Parameters.AddWithValue("@SurName",  instructor.SurName);
            addInsCmd.Parameters.AddWithValue("@Email", instructor.Email);
            addInsCmd.Parameters.AddWithValue("@Telephone", instructor.Telephone);
            addInsCmd.Parameters.AddWithValue("@Certifications", instructor.Certification);
            addInsCmd.ExecuteNonQuery();
            con.Close();
        }
        public void DeleteInstructor(int intstructorID)
        {
            if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using var con = new SqlConnection(conn);
                con.Open();
                using var delInsCmd = new SqlCommand("DELETE FROM ClassMembers WHERE ClassID IN(SELECT ClassID FROM Classes WHERE InstructorID = @InstructorID) DELETE FROM Classes WHERE InstructorID = @InstructorID DELETE FROM Instructors WHERE InstructorID = @InstructorID", con);
                delInsCmd.Parameters.Add("@InstructorID", System.Data.SqlDbType.Int).Value = intstructorID;
                delInsCmd.ExecuteNonQuery();
            }
        }
       public void UpdateSingleColumnInstructor(int instructorID_, string columnName, object newValue)
        {
            using (SqlConnection con = new SqlConnection(conn))
            {
                con.Open();

                string updateInstructorColumn = $"UPDATE Instructors SET {columnName} = @Value WHERE InstructorID = @instructorID";

                using (SqlCommand cmd = new SqlCommand(updateInstructorColumn, con))
                {
                    cmd.Parameters.AddWithValue("@InstructorID", instructorID_);

                    if (newValue == null)
                    {
                        cmd.Parameters.AddWithValue("@Value", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Value", newValue);
                    }
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }
    }
}

/* 
 * Thuesday fix instructor updating in DropBox in Class management when adding a new instructor