using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitHub.B_BLL;
using FitHub.B_BLL.ENT_OBJ;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;

namespace FitHub.C_DAL
{
    public class DalMembers
    {
        ConnectionString connectionstring = new ConnectionString();

        //A method that deletes a member from the Members tale based on their MemberID.
        public void DeleteMember(int memberID)
        {
            if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using var con = new SqlConnection(connectionstring.conn);
                con.Open();
                using var delMemCmd = new SqlCommand("DELETE FROM ClassMembers WHERE MemberID = @MemberID DELETE FROM Members WHERE MemberID = @MemberID", con);
                delMemCmd.Parameters.Add("@MemberID", System.Data.SqlDbType.Int).Value = memberID;
                delMemCmd.ExecuteNonQuery();
            }
        }


        //Takes Members table and reads them into memberList.
        public List<Member> GetAll()
        {
            List<Member> memberList = new List<Member>();
            using var con = new SqlConnection(connectionstring.conn);
            con.Open();
            using var cmd = new SqlCommand("SELECT * FROM Members", con);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                //add new memebers to memberList (if DB=null, set to default value)
                //else read the vale from the DB.
                memberList.Add(new Member
                {
                    MemberID = reader.IsDBNull(0) ? 0 : reader.GetInt32(0),
                    FirstName = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                    SurName = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                    Email = reader.IsDBNull(3) ? string.Empty : reader.GetString(3),
                    Telephone = reader.IsDBNull(4) ? string.Empty : reader.GetString(4),
                    Birthday = reader.IsDBNull(5) ? DateTime.UtcNow : reader.GetDateTime(5),
                    MemberType = reader.IsDBNull(6) ? string.Empty : reader.GetString(6),
                    Active = reader.IsDBNull(7) ? string.Empty : reader.GetString(7),
                });
            }
            con.Close();
            return memberList;
        }

        public void AddMember(Member member)
        {
            BLL bll = new BLL();
            using var con = new SqlConnection(connectionstring.conn);
            con.Open();

            string addMemberQuery = @"INSERT INTO Members (FirstName, SurName, Email, Telephone, Birthday, MemberType, Active) 
                     VALUES (@FirstName, @SurName, @Email, @Telephone, @Birthday, @MemberType, @Active)";

            using var addMemCmd = new SqlCommand(addMemberQuery, con);
            addMemCmd.Parameters.AddWithValue("@FirstName", member.FirstName);
            addMemCmd.Parameters.AddWithValue("@SurName", member.SurName);
            addMemCmd.Parameters.AddWithValue("@Email", member.Email);
            addMemCmd.Parameters.AddWithValue("@Telephone", member.Telephone);
            addMemCmd.Parameters.AddWithValue("@Birthday", member.Birthday);
            addMemCmd.Parameters.AddWithValue("@MemberType", member.MemberType);
            addMemCmd.Parameters.AddWithValue("@Active", member.Active);
            addMemCmd.ExecuteNonQuery();
            con.Close();
        }

        public void UpdateSingleColumnMember(int memberID_, string columnName, object newValue)
        {
            using (SqlConnection con = new SqlConnection(connectionstring.conn))
            {
                con.Open();

                string updateMemberColumn = $"UPDATE Members SET {columnName} = @Value WHERE MemberID = @memberID";

                using (SqlCommand cmd = new SqlCommand(updateMemberColumn, con))
                {
                    cmd.Parameters.AddWithValue("@MemberID", memberID_);

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
        public void ChangeActivity(string newStatus, int memberID)
        {
            using var con = new SqlConnection(connectionstring.conn);
            {
                con.Open();
                string changeActivityQuery = "UPDATE Members SET Active = @newStatus WHERE MemberID = @memberID";

                using (SqlCommand cmd = new SqlCommand(changeActivityQuery, con))
                {
                    cmd.Parameters.AddWithValue("@newStatus", newStatus);
                    cmd.Parameters.AddWithValue("@memberID", memberID);

                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }
    }
}
