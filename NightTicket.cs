using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BowlingLaneBooking
{
    public class NightTicket : LaneTicket
    {

        public NightTicket(int HoursBooked, int Occupants, int LaneID, int TimeBooked)
        {
            this.LaneID = LaneID;
            this.HoursBooked = HoursBooked;
            this.Occupants = Occupants;
            this.TimeBooked = TimeBooked;
            HourlyRate = 14.5;
        }

        

    }
}