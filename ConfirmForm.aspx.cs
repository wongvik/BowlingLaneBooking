using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace BowlingLaneBooking
{
    public partial class ConfirmForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            String myConnString = ConfigurationManager.ConnectionStrings["BowlingConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(myConnString);

            SqlCommand cmd = new SqlCommand("select * from Bowling", con);
            SqlDataAdapter sqlDa = new SqlDataAdapter(cmd);
            cmd.Connection.Open();

            sqlDa.Fill(dt);

            if (dt.Rows.Count > 0)
            {

                LblNameOutput.Text = dt.Rows[dt.Rows.Count - 1]["cname"].ToString();
                LblDateOutput.Text = dt.Rows[dt.Rows.Count - 1]["recDate"].ToString();
                LblTimeOutput.Text = dt.Rows[dt.Rows.Count - 1]["laneTimeSlot"].ToString();
                LblPeopleOutput.Text = dt.Rows[dt.Rows.Count - 1]["lanePeopleNo"].ToString();
                LblConfNumbOutput.Text = dt.Rows[dt.Rows.Count - 1]["recNo"].ToString();
                LblHoursOutput.Text = dt.Rows[dt.Rows.Count - 1]["laneHours"].ToString();
                LblLaneIDOutput.Text = dt.Rows[dt.Rows.Count - 1]["laneNo"].ToString();
            }
            cmd.Connection.Close();

        }

        protected void BtnSubmit_Click(object sender, EventArgs e)
        {
            // Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Thank you for reservation!');</script>");
            Response.Redirect("/ThankYou.aspx");
        }
    }
}