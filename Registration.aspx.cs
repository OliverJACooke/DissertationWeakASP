using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Dissertation__Weak_
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Submit_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=192.168.0.24;" + "Initial Catalog=WeakDB;" + "User id=usr_weak;" + "Password=%Pa55w0rd;"))
            {
                conn.Open();

                string firstName    = txt_FirstName.Value;
                string lastName     = txt_LastName.Value;
                string dob          = txt_DOB.Value;
                string eMail        = txt_EMail.Value;
                string username     = txt_username.Value;
                string password     = pwd_Password.Value;
                string rePassword   = pwd_PasswordRepeat.Value;

                using (var usernameQuery = new SqlCommand("SELECT username FROM tblUser WHERE username='" + username + "'", conn))
                {
                    var result = usernameQuery.ExecuteScalar();

                    if (result != null)
                    {
                        lbl_Valid.Text = "Username already in use";
                    }
                    else if (username == "")
                    {
                        lbl_Valid.Text = "You must enter a Username";
                    }
                    else if (password == "")
                    {
                        lbl_Valid.Text = "You must enter a Password";
                    }
                    else if (rePassword == "")
                    {
                        lbl_Valid.Text = "You must enter the Password again";
                    }
                    else if (firstName == "")
                    {
                        lbl_Valid.Text = "You must enter your First Name";
                    }
                    else if (lastName == string.Empty)
                    {
                        lbl_Valid.Text = "You must enter your Last Name";
                    }
                    else if (dob == string.Empty)
                    {
                        lbl_Valid.Text = "You must enter your Date of Birth";
                    }
                    else if (eMail == string.Empty)
                    {
                        lbl_Valid.Text = "You must enter your E-Mail";
                    }
                    else if (password != rePassword)
                    {
                        lbl_Valid.Text = "Your passwords must match";
                    }
                    else
                    {
                        using (var insertQuery = new SqlCommand("INSERT INTO tblUser (username, password, firstName, lastName, DOB, eMail) VALUES ('" + username + "','" + password + "','" + firstName + "','" + lastName + "','" + dob + "','" + eMail + "')", conn))
                        {
                            insertQuery.ExecuteNonQuery();

                            Response.Redirect("Login.aspx");
                        }
                    }
                }
            }
        }
    }
}