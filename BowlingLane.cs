using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BowlingLaneBooking
{
    public enum Status
    {
        Unoccupied,
        Occupied
    }

    public class BowlingLane 
    {
        public BowlingLane(int laneID, int maxPlayers)
        {
            this._laneStatuses = new List<Status>();
            this._laneID = laneID;
            this._maxPlayers = maxPlayers;
            for (var i = 0; i < 13; i++)
            {
                this._laneStatuses.Add(Status.Unoccupied);
            }
        }

        private int _laneID;

        public int LaneID
        {
            get { return _laneID; }
            set { _laneID = value; }
        }


        /** 
         * Assume Operating Hours goes from 12pm - 12am
         *  Each booking is at least an hour
         *  GetStatus(0) -> Gets you the status from 12pm-1pm
         *  GetStatus(1) -> Gets you the status from 1pm-2pm etc.
         *  List will be of length 12.
         **/

        private List<Status> _laneStatuses;

        public List<Status> LaneStatuses
        {
            get { return _laneStatuses; }
        }

        private int _maxPlayers;

        public int MaxPlayers {
            get
            {
                return _maxPlayers;
            }
            set
            {
                _maxPlayers = value;
            }
        }

        public Status GetStatus(int Hour)
        {
            return _laneStatuses[Hour];
        }

        public void ChangeStatus(int hour, Status status)
        {
            _laneStatuses[hour] = status;
        }
    }


}