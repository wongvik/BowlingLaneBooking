using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BowlingLaneBooking
{
    public partial class MakePayment : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            LaneTicket LaneTicket = (LaneTicket) Session["LaneTick"];
            Receipt PendingBooking = (Receipt) Session["PendingBooking"];

            double Net = (LaneTicket.HourlyRate * LaneTicket.HoursBooked);
            double Tax = (LaneTicket.HourlyRate * LaneTicket.HoursBooked * 0.13);
            double Total = (LaneTicket.HourlyRate * LaneTicket.HoursBooked * 1.13);

            LblPrice.Text = Net.ToString();
            LblTax.Text = Tax.ToString();
            LblTotal.Text = Total.ToString();

            PendingBooking.NetPrice = Net;
            PendingBooking.Tax = Tax;
            PendingBooking.Total = Total;
        }

        protected void Pay_Click(object sender, EventArgs e)
        {
            Customer Cust = (Customer) Session["Customer"];
            Receipt PendingBooking = (Receipt) Session["PendingBooking"];
            LaneTicket LaneTick = (LaneTicket)Session["LaneTick"];

            String ExpDate = DropDownListExpMon.SelectedValue + "/" + DropDownListExpYear.SelectedValue;
            PaymentMake obj = new PaymentMake
            {
                cardName = txtCardName.Text,
                cardNumber = txtCardNum.Text,
                date = ExpDate,
                secCode = txtSecCode.Text
            };
            
            LaneStatusAccessLayer.addPaymentRecord(obj);
            LaneStatusAccessLayer.addRecord(Cust, PendingBooking, LaneTick);
            
            Response.Redirect("~/ConfirmForm.aspx");
        }
        
    }
}