﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BowlingLaneBooking
{
    public partial class ThankYou : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnEnjoy_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Default.aspx");
        }
    }
}