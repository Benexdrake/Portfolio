using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV_to_SQL
{
    public class Records
    {
        int customerID;
        int performanceID;
        int quantity;
        double price;
        string date;
        string designation;

        public int CustomerID { get { return customerID; } set { customerID = value; } }
        public int PerformanceID { get { return performanceID; } set { performanceID = value; } }
        public int Quantity { get { return quantity; } set { quantity = value; } }
        public double Price { get { return price; } set { price = value; } }
        public string Date { get { return date; } set { date = value; } }
        public string Designation { get { return designation; } set { designation = value; } }

        public override bool Equals(object? obj)
        {
            return obj is Records records &&
                   customerID == records.customerID &&
                   performanceID == records.performanceID &&
                   quantity == records.quantity &&
                   price == records.price &&
                   date == records.date &&
                   designation == records.designation;
        }
    }
}
