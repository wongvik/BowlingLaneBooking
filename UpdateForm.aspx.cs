using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BowlingLaneBooking
{
    public partial class UpdateForm : System.Web.UI.Page
    {
        Receipt Rec;
        protected void Page_Load(object sender, EventArgs e)
        {
            BtnUpdate.Enabled = false;
        }
        protected void BtnCheck_Click(object sender, EventArgs e)
        {
            Rec = LaneStatusAccessLayer.getReceipt(TxtName.Text, TxtPhone.Text, TxtEmail.Text);
            Session["Rec"] = Rec;
            if (Rec != null)
            {
                BtnUpdate.Enabled = true;
                BtnUpdate.CssClass = "btn";
                LblReceiptNo.Text = Rec.ReceiptNo;
                LblTimeSlot.Text = Rec.TimeBooked.ToString();
                LblTotal.Text = Rec.Total.ToString();
            }
            else
            {
                LblReceiptNo.Text = "Booking Not Found!";
                LblTimeSlot.Text = "";
                LblTotal.Text = "";
            }
        }

        protected void BtnUpdate_Click(object sender, EventArgs e)
        {
            Customer cust = new Customer
            {
                Name = TxtName.Text,
                Phone = TxtPhone.Text,
                Email = TxtEmail.Text
            };

            Receipt RecNo = (Receipt) Session["Rec"];
            int ReturnStatus = LaneStatusAccessLayer.updateCustomer(cust, RecNo.ReceiptNo);

            if (ReturnStatus != 0) // 0 is unsuccessful
            {
                LblReceiptNo.Text = "Information Update Success!";
                LblTimeSlot.Text = "";
                LblTotal.Text = "";
            }
            else 
            {
                LblReceiptNo.Text = "Information Update Unuccessful";
                LblTimeSlot.Text = "";
                LblTotal.Text = "";
            }
        }

        protected void BtnDelete_Click(object sender, EventArgs e)
        {
            Receipt Recpt = (Receipt)Session["Rec"];

            int ReturnStatus = LaneStatusAccessLayer.deleteRecord(Recpt.ReceiptNo);

            if (ReturnStatus != 0) // 0 is unsuccessful
            {
                LblReceiptNo.Text = "Booking has been cancelled!";
                LblTimeSlot.Text = "";
                LblTotal.Text = "";
            }
            else
            {
                LblReceiptNo.Text = "Booking Cancellation was unsuccessful.";
                LblTimeSlot.Text = "";
                LblTotal.Text = "";
            }
        }
    }
}