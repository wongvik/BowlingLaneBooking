using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BowlingLaneBooking
{
    public class Customer
    {
        private int _custID;

        public int CustomerID
        {
            get { return _custID; }
            set { _custID = value; }
        }

        private String _name;

        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private String _phone;

        public String Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        private String _street;

        public String Street
        {
            get { return _street; }
            set { _street = value; }
        }

        private String _unit;

        public String Unit
        {
            get { return _unit; }
            set { _unit = value; }
        }

        private String _city;

        public String City
        {
            get { return _city; }
            set { _city = value; }
        }

        private String _prov;

        public String Province
        {
            get { return _prov; }
            set { _prov = value; }
        }

        private String _pcode;

        public String Pcode
        {
            get { return _pcode; }
            set { _pcode = value; }
        }

        private String _email;

        public String Email
        {
            get { return _email; }
            set { _email = value; }
        }

        private List<Receipt> _receipts;

        public List<Receipt> Receipts
        {
            get { return _receipts; }
            set { _receipts = value; }
        }
        

    }
}