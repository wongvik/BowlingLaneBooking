using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BowlingLaneBooking
{
    public class LaneTicket
    {
        private int _hoursBooked;

        public int HoursBooked
        {
            get { return _hoursBooked; }
            set { _hoursBooked = value; }
        }

        private int _laneID;

        public int LaneID
        {
            get { return _laneID; }
            set { _laneID = value; }
        }

        private int _occupants;

        public int Occupants
        {
            get { return _occupants; }
            set { _occupants = value; }
        }
        
        private double _hourlyRate;

        public double HourlyRate
        {
            get { return _hourlyRate; }
            set { _hourlyRate = value; }
        }

        private int _timeBooked;

        public int TimeBooked
        {
            get { return _timeBooked; }
            set { _timeBooked = value; }
        }
    }
}