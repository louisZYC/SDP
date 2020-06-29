using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDP_Project.Entity
{
    public class SalesItem : IEquatable<SalesItem>
    {
        //!
        public int amount { get; set; }
        public String productid { get; set; }
        public String productname { get; set; }
        public decimal price { get; set; }
        public int discount { get; set; } //int
        public String salesdate{get;set;}

        public String Remark { get; set; }


        public bool Equals(SalesItem other)
        {
            if (other == null) return false;
            return (this.productid.Equals(other.productid));
        }

        public override string ToString()
        {
            return "ID: " + productid + "   amount: " + amount;
        }

        public decimal calTotal()
        {
            decimal total = amount * price - discount;
            return total;
        }

        public decimal calSubTotal()
        {
            decimal subtotal = amount * price;
            return subtotal;
        }
    }
}
