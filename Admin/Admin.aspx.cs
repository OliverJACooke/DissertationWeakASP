using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data.Linq;

namespace Dissertation__Weak_.Admin
{
    public partial class UserManagement : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection("Data Source=192.168.0.24;" + "Initial Catalog=WeakDB;" + "User id=usr_weak;" + "Password=%Pa55w0rd;");
        

        protected void Page_Load(object sender, EventArgs e)
        {
            conn.Open();
            var UserID = Session["LoggedIn"];

            var adminSQL = new SqlCommand("SELECT admin FROM tblUser WHERE userID=" + Convert.ToInt32(UserID), conn);

            int admin = Convert.ToInt32(adminSQL.ExecuteScalar());

            if (UserID == null)
            {
                Response.Redirect("../Login.aspx");
            }
            else if (admin != 1)
            {
                Response.Redirect("../Members/Home.aspx");
            }
            else
            {

                var usernameSQL = new SqlCommand("SELECT username FROM tblUser WHERE userID=" + Convert.ToInt32(UserID), conn);

                var Username = usernameSQL.ExecuteScalar();

                lbl_Welcome.Text = "Welcome " + Username;
            }
        }

        protected void Search_Click(object sender, EventArgs e)
        {
            var sUsername = searchUsername.Value;


            var userSQL = new SqlCommand("SELECT userID, username, firstName, lastName, DOB, eMail, admin FROM tblUser WHERE username='" + sUsername + "'", conn);

            SqlDataReader reader = userSQL.ExecuteReader();

            if (reader.Read())
            {
                userID.Text         = Convert.ToString(reader[0]);
                username.Text       = Convert.ToString(reader[1]);
                txt_firstName.Value = Convert.ToString(reader[2]);
                txt_lastName.Value  = Convert.ToString(reader[3]);
                txt_dob.Value       = Convert.ToString(reader[4]);
                txt_eMail.Value     = Convert.ToString(reader[5]);
                chk_Admin.Checked   = Convert.ToBoolean(reader[6]);
            }
            else
            {
                lbl_Valid.Text = "No User Found";
            }
		
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            int UserID          = Convert.ToInt32(userID.Text);
            string firstName    = txt_firstName.Value;
            string lastName     = txt_lastName.Value;
            string dob          = txt_dob.Value;
            string eMail        = txt_eMail.Value;
            bool chkAdmin       = chk_Admin.Checked;

            if (firstName == string.Empty)
            {
                lbl_Valid.Text = "You must enter a First Name";
            }
            else if (lastName == string.Empty)
            {
                lbl_Valid.Text = "You must enter a Last Name";
            }
            else if (dob == string.Empty)
            {
                lbl_Valid.Text = "You must enter a Date of Birth";
            }
            else if (eMail == string.Empty)
            {
                lbl_Valid.Text = "You must enter a E-Mail";
            }
            else
            {
                
                var userSQL = new SqlCommand("UPDATE tblUser SET firstName='"+ firstName +"',lastName='"+ lastName +"', DOB='" + dob+"',eMail='"+ eMail+"',admin="+ Convert.ToInt32(chkAdmin) +" WHERE userID='" + UserID + "'", conn);

                userSQL.ExecuteNonQuery();
                
            }
        }

        protected void Delete_Click(object sender, EventArgs e)
        {

            var deleteSQL = new SqlCommand("DELETE FROM tblUser WHERE userID =" + Convert.ToInt32(userID.Text));

            deleteSQL.ExecuteNonQuery();
        }
    }
}