using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BowlingLaneBooking
{
    public class Employee
    {
        private int _empId;
        public int EmpId
        {
            get { return _empId; }
            set { _empId = value; }
        }

        private string _empName;

        public string EmpName
        {
            get { return _empName; }
            set { _empName = value; }
        }



    }

}