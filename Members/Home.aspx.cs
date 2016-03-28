using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Dissertation__Weak_.Members
{

    public partial class Home : System.Web.UI.Page
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
                gridviewBind();
            }

        }

        public void gridviewBind()
        {
            var messageType = dd_MessageType.SelectedItem.Value;

                conn.Open();
                var usernameSQL = new SqlCommand("SELECT username FROM tblUser WHERE userID=" + Session["LoggedIn"], conn);
                
                    var Username = usernameSQL.ExecuteScalar();

                    lbl_Welcome.Text = "Welcome " + Username;


                    if (messageType == "")
                    {
                        messageType = "Public";
                    }


                    if (messageType == "Public")
                    {
                        using (var sql = new SqlCommand("SELECT tblUser.username,tblMessage.messageBody FROM tblMessage INNER JOIN tblUser on tblMessage.userID= tblUser.userID  WHERE messageType=0", conn))
                        {
                            SqlDataReader reader = sql.ExecuteReader();
                            gvMessage.DataSource = reader;
                            gvMessage.DataBind();
                        }
                    }
                    else if (messageType == "Private")
                    {
                        using (var sql = new SqlCommand("SELECT tblUser.username,tblMessage.messageBody FROM tblMessage INNER JOIN tblUser on tblMessage.userID= tblUser.userID  WHERE messageType=1 AND username='" + Username + "'", conn))
                        {
                            SqlDataReader reader = sql.ExecuteReader();
                            gvMessage.DataSource = reader;
                            gvMessage.DataBind();
                        }
                    
                }
            
        }

        protected void dd_MessageType_SelectedIndexChanged(object sender, EventArgs e)
        {
            gridviewBind();
        }
    }
}