using FitHub._2._BusinessLogicLayer.ENT_OBJ;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitHub._3._DataAccessLayer
{
    //Everyone has participated
    public class DalClasses
    {
        ConnectionString connectionstring = new ConnectionString();

        // Retrieves all upcoming classes along with their instructor details.
        public List<Class> GetAllClassesDAL()
        {
            List<Class> classList = new List<Class>();
            using var con = new SqlConnection(connectionstring.conn);
            con.Open();

            using var cmd = new SqlCommand(@"
        SELECT c.ClassID, c.ClassDate, c.ClassTime, c.ClassLocation, c.ClassType, c.ClassCapacity,
                i.InstructorID, i.FirstName, i.SurName
        FROM Classes c
        INNER JOIN Instructors i ON c.InstructorID = i.InstructorID
        WHERE c.ClassDate >= CAST(GETDATE() AS DATE)
        ORDER BY c.ClassDate, c.ClassTime ASC;", con);

            using var reader = cmd.ExecuteReader();

            // Get ordinals for better performance
            int ordClassID = reader.GetOrdinal("ClassID");
            int ordClassDate = reader.GetOrdinal("ClassDate");
            int ordClassTime = reader.GetOrdinal("ClassTime");
            int ordClassLocation = reader.GetOrdinal("ClassLocation");
            int ordClassType = reader.GetOrdinal("ClassType");
            int ordClassCapacity = reader.GetOrdinal("ClassCapacity");
            int ordInstructorID = reader.GetOrdinal("InstructorID");
            int ordFirstName = reader.GetOrdinal("FirstName");
            int ordSurName = reader.GetOrdinal("SurName");

            while (reader.Read())
            {
                // Handle ClassTime which may be stored as TimeSpan or string
                string classTimeString = string.Empty;
                if (!reader.IsDBNull(ordClassTime))
                {
                    var fieldType = reader.GetFieldType(ordClassTime);
                    if (fieldType == typeof(TimeSpan))
                    {
                        classTimeString = reader.GetTimeSpan(ordClassTime).ToString(@"hh\:mm");
                    }
                    else
                    {
                        classTimeString = reader.GetString(ordClassTime);
                    }
                }
                // Populate Class object and add to list
                classList.Add(new Class
                {
                    ClassID = reader.IsDBNull(ordClassID) ? 0 : reader.GetInt32(ordClassID),
                    ClassDate = reader.IsDBNull(ordClassDate) ? DateTime.UtcNow : reader.GetDateTime(ordClassDate),
                    ClassTime = classTimeString,
                    ClassLocation = reader.IsDBNull(ordClassLocation) ? string.Empty : reader.GetString(ordClassLocation),
                    ClassType = reader.IsDBNull(ordClassType) ? string.Empty : reader.GetString(ordClassType),
                    ClassCapacity = reader.IsDBNull(ordClassCapacity) ? string.Empty : reader.GetString(ordClassCapacity),
                    InstructorID = reader.IsDBNull(ordInstructorID) ? 0 : reader.GetInt32(ordInstructorID),
                    FirstName = reader.IsDBNull(ordFirstName) ? string.Empty : reader.GetString(ordFirstName),
                    SurName = reader.IsDBNull(ordSurName) ? string.Empty : reader.GetString(ordSurName),
                });
            }
            con.Close();
            return classList;
        }

        public void AddClassDAL(Class classes)
        {
            // Ensure ClassDate contains only the date portion and ClassTime contains only the time.
            DateTime classDateOnly = classes.ClassDate.Date;

            // Normalize ClassTime: prefer TimeSpan (suitable for SQL TIME), otherwise string "HH:mm".
            object classTimeParam = DBNull.Value;
            if (!string.IsNullOrWhiteSpace(classes.ClassTime))
            {
                if (TimeSpan.TryParse(classes.ClassTime, out var ts))
                {
                    classTimeParam = ts; // send TimeSpan so SQL TIME column receives only time
                }
                else if (DateTime.TryParse(classes.ClassTime, out var dt))
                {
                    classTimeParam = dt.TimeOfDay;
                }
                else
                {
                    // fallback: keep  HH:mm if parsing fails
                    classTimeParam = classes.ClassTime;
                }
            }

            using var con = new SqlConnection(connectionstring.conn);
            con.Open();
            using var cmd = new SqlCommand(@"
        INSERT INTO Classes (InstructorID, ClassDate, ClassTime, ClassLocation, ClassType, ClassCapacity)
        VALUES (@InstructorID, @ClassDate, @ClassTime, @ClassLocation, @ClassType, @ClassCapacity);", con);

            cmd.Parameters.AddWithValue("@InstructorID", classes.InstructorID);
            // store date-only (midnight time) in ClassDate column
            cmd.Parameters.AddWithValue("@ClassDate", classDateOnly);
            // store only time in ClassTime column (TimeSpan maps to SQL TIME)
            cmd.Parameters.AddWithValue("@ClassTime", classTimeParam);
            cmd.Parameters.AddWithValue("@ClassLocation", string.IsNullOrWhiteSpace(classes.ClassLocation) ? (object)DBNull.Value : classes.ClassLocation);
            cmd.Parameters.AddWithValue("@ClassType", string.IsNullOrWhiteSpace(classes.ClassType) ? (object)DBNull.Value : classes.ClassType);
            cmd.Parameters.AddWithValue("@ClassCapacity", classes.ClassCapacity);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        // Returns current instructors so the UI can refresh the class-management instructor drop-down.
        public List<Instructor> UpdateClassManInstructorDropBox()
        {
            var dalInstructor = new DalInstructor();
            return dalInstructor.GetAllInstructors();
        }

        // Updates a single column of a class based on ClassID (CellEndEdit)
        public void UpdateSingleColumnClass(int classID, string columnName, object newValue)
        {
            using (SqlConnection con = new SqlConnection(connectionstring.conn))
            {
                con.Open();

                string updateClassColumn = $"UPDATE Classes SET {columnName} = @Value WHERE ClassID = @classID";

                using (SqlCommand cmd = new SqlCommand(updateClassColumn, con))
                {
                    cmd.Parameters.AddWithValue("@classID", classID);

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
