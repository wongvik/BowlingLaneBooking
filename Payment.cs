using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BowlingLaneBooking
{

    public class Payment
    {
        private Double _tax;

        public Double Tax
        {
            get { return _tax; }
            set { _tax = value; }
        }

        private Double _total;

        public Double Total
        {
            get { return _total; }
            set { _total = value; }
        }

        private String _cardHolderName;

        public String CardHolderName
        {
            get { return _cardHolderName; }
        }

        private long _cardNumber;

        public long CardNumber
        {
            get { return _cardNumber; }
        }

        private DateTime _expiryDate;

        public DateTime Expirydate
        {
            get { return _expiryDate; }
        }

        private int _securityCode;

        public int SecurityCode
        {
            get { return _securityCode; }
            set { _securityCode = value; }
        }








    }
}