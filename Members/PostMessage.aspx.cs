using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Dissertation__Weak_.Members
{
    public partial class PostMessage : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection("Data Source=192.168.0.24;" + "Initial Catalog=WeakDB;" + "User id=usr_weak;" + "Password=%Pa55w0rd;");

        protected void Page_Load(object sender, EventArgs e)
        {
            var UserID = Session["LoggedIn"];

            if (UserID == null)
            {
                Response.Redirect("../Login.aspx");
            }
            else
            {
                conn.Open();
                var usernameSQL = new SqlCommand("SELECT username FROM tblUser WHERE userID=" + Convert.ToInt32(UserID), conn);

                var Username = usernameSQL.ExecuteScalar();

                lbl_Welcome.Text = "Welcome " + Username;
                pnl_UserPanel.Visible = false;
            }
        }

        protected void btn_SubmitMessage_Click(object sender, EventArgs e)
        {
            
            int UserID = Convert.ToInt32(Session["LoggedIn"]);
            bool chkPrivate = chk_Private.Checked;
            string submitUsername = txt_Username.Value;
            string message = txt_Message.Value;


            var dbUserSQL = new SqlCommand("SELECT username FROM tblUser WHERE username='" + submitUsername+"'", conn);

            var dbUsername = dbUserSQL.ExecuteScalar();

            if (chk_Private.Checked == true && dbUsername == null)
            {
                lbl_Valid.Text = "User does not exist";
            }
            else if (message == "")
            {
                lbl_Valid.Text = "You must enter a message";
            }
            else
            {

                var insertmessageSQL = new SqlCommand("INSERT INTO tblMessage (userID, messageBody, messageType, username) VALUES ('" + UserID + "','" + message + "'," + Convert.ToInt32(chkPrivate) + ",'" + submitUsername + "')", conn);

                insertmessageSQL.ExecuteNonQuery();
            }
        }

        protected void chk_Private_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Private.Checked == true)
            {
                pnl_UserPanel.Visible = true;
            }
            else if (chk_Private.Checked == false)
            {
                pnl_UserPanel.Visible = false;
            }

        }
    }
}