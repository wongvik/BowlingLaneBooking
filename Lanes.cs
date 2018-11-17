using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BowlingLaneBooking
{
    public class Lanes
    {
        public Lanes()
        {
            this.BowlingLanes = new List<BowlingLane>();

            for (var i = 0; i < 16; i++)
            {
                BowlingLane lane = new BowlingLane(i, 7);
                this.BowlingLanes.Add(lane);
            }

        }

        private List<BowlingLane> _bowlinglanes;

        public List<BowlingLane> BowlingLanes
        {
            get { return _bowlinglanes; }
            set { _bowlinglanes = value; }
        }

        public Status GetStatus(int LaneID, int Hour)
        {
            BowlingLane lane =  _bowlinglanes[LaneID];
            return lane.GetStatus(Hour);
        }

        public bool CheckAvailOfLane(int LaneID, List<int> Hours)
        {
            BowlingLane lane = _bowlinglanes[LaneID];
            bool Availability = true;

            for (int i = 0; i < Hours.Count; i++)
            {
                if (lane.GetStatus(Hours[i]) == Status.Occupied)
                {
                    Availability = false;
                }
            }
            return Availability;
        }

        public int CheckAvailOfAllLanes(List<int> Hours)
        {
            bool Available;
            //Number of Lanes
            int LaneNum = this.BowlingLanes.Count;

            // Loop through every bowling lane
            for (int LaneID = 0; LaneID < LaneNum; LaneID++)
            {
                Available = this.CheckAvailOfLane(LaneID, Hours);
                if (Available)
                {
                    return LaneID;
                }
            }
            return -1;
        }

       
    }
}