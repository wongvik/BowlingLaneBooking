using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace BowlingLaneBooking


{
    public class PaymentMake
    {
        public String cardName { get; set; }
        public String cardNumber { get; set; }
        public String date { get; set; }
        public String secCode { get; set; }
        

    }
    public class InfoForView {
        public int recNo { get; set; }
        public String cname { get; set; }
        public String laneTime { get; set; }
        public int lanePeopleNo { get; set; }
        public int laneNo { get; set; }
        public DateTime recDate { get; set; }
        public double recTotal { get; set; }
    }

    public class LaneStatusAccessLayer
    {
        public static List<InfoForView> getInfo()
        {
            List<InfoForView> listRecord = new List<InfoForView>();
            string cs = ConfigurationManager.ConnectionStrings["BowlingConnectionString"].ConnectionString;

            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("select * from Bowling", con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    InfoForView obj = new InfoForView();
                    obj.recNo = Convert.ToInt32(rdr["recNo"]);
                    obj.cname = rdr["cname"].ToString();
                    obj.laneTime = rdr["laneTime"].ToString();
                    obj.lanePeopleNo = Convert.ToInt32(rdr["lanePeopleNo"]);
                    obj.laneNo = Convert.ToInt32(rdr["laneNo"]);
                    obj.recDate = Convert.ToDateTime(rdr["recDate"]);
                    obj.recTotal = Convert.ToDouble(rdr["recTotal"]);

                    listRecord.Add(obj);
                }
            }

            return listRecord;
        }

        public static int updateCustomer(Customer cust, String ReceiptNo)
        {
            int a = 0;
            string cs = ConfigurationManager.ConnectionStrings["BowlingConnectionString"].ConnectionString;

            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("update Bowling set cname=@cname, cphone=@cphone, cemail=@cemail where recNo=@recNo", con);
                con.Open();
                cmd.Parameters.AddWithValue("cname", cust.Name);
                cmd.Parameters.AddWithValue("cphone", cust.Phone);
                cmd.Parameters.AddWithValue("cemail", cust.Email);
                cmd.Parameters.AddWithValue("recNo", ReceiptNo);
                a = cmd.ExecuteNonQuery();
            }
            return a;
        }

        public static List<BowlingLane> getAllStatuses(List<BowlingLane> BowlingLanes)
        {
            List<BowlingLane> listLane = new List<BowlingLane>();
            string cs = ConfigurationManager.ConnectionStrings["BowlingConnectionString"].ConnectionString;

            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("select * from Bowling", con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    for (int id = 0; id < BowlingLanes.Count; id++)
                    {
                        if(Convert.ToInt32(rdr["laneNo"]) == id)
                        {
                            // Assuming 0 = 12pm etc
                            int laneTime = Convert.ToInt32(rdr["laneTimeSlot"]);
                            int laneHours = Convert.ToInt32(rdr["laneHours"]);

                            for (int hour = laneTime; hour < (laneHours+laneTime); hour++)
                            {
                                BowlingLanes[id].ChangeStatus(hour, Status.Occupied);
                            }
                            
                        }
                    }
                }
            }
            return BowlingLanes;
        }

        public static void addRecord(Customer cust, Receipt receipt, LaneTicket laneTick )
        {
            string cs = ConfigurationManager.ConnectionStrings["BowlingConnectionString"].ConnectionString;

            using (SqlConnection con = new SqlConnection(cs))
            {
                // @Id -> SQL Params -> Prevent Injection 
                SqlCommand cmd = new SqlCommand("insert into Bowling values (@cname, @cphone, " +
                    "@cstreet, @cunit, @ccity, @cprov, @cpcode, @cemail, @hourlyRate, @laneTimeSlot, " +
                    "@laneHours, @lanePeopleNo, @laneNo, @recDate, @recTotal)", con);
                con.Open();
                cmd.Parameters.AddWithValue("cname", cust.Name);
                cmd.Parameters.AddWithValue("cphone", cust.Phone);
                cmd.Parameters.AddWithValue("cstreet", cust.Street);
                cmd.Parameters.AddWithValue("cunit", cust.Unit);
                cmd.Parameters.AddWithValue("ccity", cust.City);
                cmd.Parameters.AddWithValue("cprov", cust.Province);
                cmd.Parameters.AddWithValue("cpcode", cust.Pcode);
                cmd.Parameters.AddWithValue("cemail", cust.Email);
                cmd.Parameters.AddWithValue("hourlyRate", laneTick.HourlyRate);
                cmd.Parameters.AddWithValue("laneTimeSlot", receipt.TimeBooked);
                cmd.Parameters.AddWithValue("laneHours", receipt.HoursBooked);
                cmd.Parameters.AddWithValue("lanePeopleNo", laneTick.Occupants);
                cmd.Parameters.AddWithValue("laneNo", laneTick.LaneID);
                cmd.Parameters.AddWithValue("recDate", receipt.ReceiptDate);
                cmd.Parameters.AddWithValue("recTotal", receipt.Total);

                cmd.ExecuteNonQuery();

        
            }
        }


        public static void addPaymentRecord(PaymentMake obj)
        {
            string cs = ConfigurationManager.ConnectionStrings["BowlingConnectionString"].ConnectionString;

            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("insert into payment values (@cardName,@cardNumber,@secCode,@date)", con);
                con.Open();
                cmd.Parameters.AddWithValue("cardName", obj.cardName);
                cmd.Parameters.AddWithValue("cardNumber", obj.cardNumber);
                cmd.Parameters.AddWithValue("date", obj.date);
                cmd.Parameters.AddWithValue("secCode", obj.secCode);
                

                cmd.ExecuteNonQuery();

            }
        }


        public static int deleteRecord(String ReceiptNo)
        {
            int a = 0;
            string cs = ConfigurationManager.ConnectionStrings["BowlingConnectionString"].ConnectionString;

            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("delete from Bowling where recNo=@recNo", con);
                con.Open();
                cmd.Parameters.AddWithValue("recNo", ReceiptNo);
                a = cmd.ExecuteNonQuery();
            }
            return a;
        }



        public static Receipt getReceipt(string Name, string Phone, string Email)
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["BowlingConnectionString"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("Select * from Bowling where cname=@cname AND cphone=@cphone AND cemail=@cemail", con);
                con.Open();
                cmd.Parameters.AddWithValue("cname", Name);
                cmd.Parameters.AddWithValue("cphone", Phone);
                cmd.Parameters.AddWithValue("cemail", Email);

                Receipt rec = null;
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        rec = new Receipt();
                        rec.ReceiptNo = reader["recNo"].ToString();
                        rec.TimeBooked = Int32.Parse((String)reader["laneTimeSlot"]);
                        rec.Total = (double) reader["recTotal"];
                    }
                }

                return rec;
            }
            catch (Exception e)
            {
                return new Receipt { ReceiptNo = "Unable to retrieve receipt." };
            }
        }
    }
}