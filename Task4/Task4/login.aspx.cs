using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace Task4
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            incorrecttext.Visible = false;
            if (!IsPostBack)
            {
                if (Request.Cookies["username"] != null && Request.Cookies["password"] != null)
                {
                    usertext.Text = Request.Cookies["username"].Value;
                    passtext.Attributes["value"] = Request.Cookies["password"].Value;
                }
            }
        }
        protected void loginbtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;
                                                                AttachDbFilename=|DataDirectory|\task4.mdf;Integrated Security=True"))
            {
                sqlCon.Open();
                string query = "SELECT COUNT(*) FROM [user] WHERE username=@username AND password=@password";
                SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                sqlCmd.Parameters.AddWithValue("@username", usertext.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@password", passtext.Text.Trim());

                int count = Convert.ToInt32(sqlCmd.ExecuteScalar());

                if (rememberme.Checked)
                {
                    Response.Cookies["username"].Expires = DateTime.Now.AddDays(30);
                }
                else
                {
                    Response.Cookies["username"].Expires = DateTime.Now.AddDays(-1);
                }
                Response.Cookies["username"].Value = usertext.Text.Trim();

                if (count > 0)
                {
                    Session["username"] = usertext.Text.Trim();
                    Response.Redirect("default.aspx");
                }
                else
                {
                    incorrecttext.Visible = true;
                }
            }
        }

        protected void rememberme_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}