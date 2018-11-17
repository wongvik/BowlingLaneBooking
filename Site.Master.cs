using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BowlingLaneBooking
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Lanes lanes = new Lanes();
            lanes.BowlingLanes = LaneStatusAccessLayer.getAllStatuses(lanes.BowlingLanes);
            Session["Lanes"] = lanes;
        }

        protected void LinkBtnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Default.aspx");
        }

        protected void LinkBtnBook_Click(object sender, EventArgs e)
        {
            Response.Redirect("/BookingPage.aspx");
        }


        protected void LinkBtbAboutUs_Click(object sender, EventArgs e)
        {
            Response.Redirect("/About.aspx");
        }

        protected void LinkBtnBowling_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Tips.aspx");
        }

        protected void LinkBtnContact_Click(object sender, EventArgs e)
        {
            Response.Redirect("/ContactUs.aspx");
        }


        protected void LinkBtnUpdate_Click(object sender, EventArgs e)
        {
            Response.Redirect("/UpdateForm.aspx");
        }


    }
}