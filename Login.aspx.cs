using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Dissertation__Weak_
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Submit_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=192.168.0.24;" + "Initial Catalog=WeakDB;" + "User id=usr_weak;" + "Password=%Pa55w0rd;"))
            conn.Open();

            string Username = txt_username.Value;
            string Password = pwd_password.Value;

            if (Username == "")                
            {
                    lbl_Valid.Text = "You must enter a Username";
            }
            else if (Password == "")
            {
                lbl_Valid.Text = "You must enter a Password";
            }
            else
            {
                var sql = new SqlCommand("SELECT userID FROM tblUser WHERE username='" + Username + "' and password='" + Password + "'", conn)

                var result = sql.ExecuteScalar();

                if (result != null)
                {
                    Session["LoggedIn"] = result;
                    Response.Redirect("Members/Home.aspx");
                }
                else
                {
                    lbl_Valid.Text = "Incorrect Username or Password";
                }
            }
        }
    }
}
