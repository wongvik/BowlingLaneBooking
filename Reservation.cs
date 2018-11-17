using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BowlingLaneBooking
{
    public class Reservation
    {

        private List<BowlingLane> _bowlingLanes;

        public List<BowlingLane> BowlingLanes
        {
            get { return _bowlingLanes; }
            set { _bowlingLanes = value; }
        }

        private void AddReservation(int Time, int LaneID) {

        }

        private void CancelReservation(int Time, int LaneID) {

        }

        private void ConfirmReservation(int Time, int LaneID) {

        }

        public static List<BowlingLane> GetBowlingLanes(int laneId, int maxPlayers, int numberOfLanes)
        {
            List <BowlingLane> bowlingLanes= new List<BowlingLane>();
            for (int i = 0; i < numberOfLanes; i++)
            {
                bowlingLanes.Add(new BowlingLane(laneId, maxPlayers));
            }
            return bowlingLanes;

        }

        public static void AddBowlingLanes() {

        }

        public static Status GetBowlingLaneStatus(int Time, int LaneId) {
            //need to make some logit depending on time return lane occupied or not
            return Status.Occupied;
        }


    }
}