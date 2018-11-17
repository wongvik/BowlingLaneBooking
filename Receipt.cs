using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BowlingLaneBooking
{
    public class Receipt
    {
        private string _receiptNo;

        public string ReceiptNo
        {
            get { return _receiptNo; }
            set { _receiptNo = value; }
        }

        private string _receiptDate;

        public string ReceiptDate
        {
            get { return _receiptDate; }
            set { _receiptDate = value; }
        }

        private int _hoursBooked;

        public int HoursBooked
        {
            get { return _hoursBooked; }
            set { _hoursBooked = value; }
        }

        private double _netprice;

        // Starting time to book
        private int _timeBooked;

        public int TimeBooked
        {
            get { return _timeBooked; }
            set { _timeBooked = value; }
        }
        
        public double NetPrice
        {
            get { return _netprice; }
            set { _netprice = value; }
        }

        private double _total;

        public double Total
        {
            get { return _total; }
            set { _total = value; }
        }

        private double _tax;

        public double Tax
        {
            get { return _tax; }
            set { _tax = value; }
        }
        
    }
}