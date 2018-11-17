using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BowlingLaneBooking
{
    public partial class BookingPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BtnShowAvail.Enabled = false;
            BtnShowAvail.CssClass = "btn";

            LinkBtnPayment.Enabled = false;
            LinkBtnPayment.CssClass = "btn";
        }

        protected void DropDownsSelected()
        {
            if (DropDownNumHours.SelectedIndex > 0 && DropDownNumPpl.SelectedIndex > 0 && DropDownTime.SelectedIndex > 0)
            {
                BtnShowAvail.Enabled = true;
            }
        }

        protected void DropDownTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownsSelected();
        }

        protected void DropDownNumHours_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownsSelected();
        }

        protected void DropDownNumPpl_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownsSelected();
        }

        protected void BtnShowAvail_Click(object sender, EventArgs e)
        {
            Lanes LanesStatuses = (Lanes)(Session["Lanes"]);

            // Selected Number of Hours to book (How Long)
            int NumHours = Int32.Parse(DropDownNumHours.SelectedValue);

            // Selected Time Slot to start ex: 0 -> 12pm
            int TimeSlotToStart = Int32.Parse(DropDownTime.SelectedValue);

            // Timeslots they have selected ex: 12pm, 1pm 
            List<int> HoursToBook = new List<int>();
            for (int i = 0; i < NumHours; i++)
            {
                HoursToBook.Add(TimeSlotToStart + i);
            }

            // If booking goes past 
            if (HoursToBook[HoursToBook.Count() - 1] > 12)
            {
                LblAvailable.Text = "Selected time is over our open hours.\n" +
                    "Please select a different time slot.";
            }
            else
            {
                int AvailableLane = LanesStatuses.CheckAvailOfAllLanes(HoursToBook);

                if (AvailableLane == -1)
                {
                    LblAvailable.Text = "It is not available. Please select a different time slot.";
                    LinkBtnPayment.Enabled = false;
                }
                else
                {
                    LblAvailable.Text = "It is available!";

                    LaneTicket LaneTick;
                    int PlayerNum = Int32.Parse(DropDownNumPpl.SelectedValue);
                    int BookedTime = Int32.Parse(DropDownTime.SelectedValue);

                    // 6pm and after -> Night ticket, else -> Day ticket
                    if (Int32.Parse(DropDownTime.SelectedValue) > 5)
                    {
                        LaneTick = (LaneTicket) new NightTicket(NumHours, PlayerNum, AvailableLane, BookedTime);
                    }
                    else
                    {
                        LaneTick = (LaneTicket)new DayTicket(NumHours, PlayerNum, AvailableLane, BookedTime);
                    }

                    Session["LaneTick"] = LaneTick;
                    LinkBtnPayment.Enabled = true;
                }
            }

        }

        protected void LinkBtnPayment_Click(object sender, EventArgs e)
        {
            Customer Cust = new Customer
            {
                Name = txtName.Text,
                Phone = txtPhone.Text,
                Street = txtStreet.Text,
                City = txtCity.Text,
                Pcode = txtPostal.Text,
                Unit = txtUnit.Text,
                Province = dropDownProv.SelectedValue,
                Email = TxtEmail.Text
            };

            DateTime now = DateTime.Now;
            string sqlFormattedDate = now.ToString("yyyy-MM-dd");

            Receipt PendingBooking = new Receipt
            {
                HoursBooked = Int32.Parse(DropDownNumHours.SelectedValue),
                TimeBooked = Int32.Parse(DropDownTime.SelectedValue),
                ReceiptDate = sqlFormattedDate
            };
            
            Session["Customer"] = Cust;
            Session["PendingBooking"] = PendingBooking;
            
            Response.Redirect("~/MakePayment.aspx");
        }
        
    }
}