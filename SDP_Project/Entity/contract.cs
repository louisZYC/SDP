using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SDP_Project.Entity;

namespace SDP_Project.Entity
{
    public class contract : IEquatable<contract>
    {
        public tenant tenant { get; set; }
        public String contractID { get; set; }
        public String showcaseID { get; set; }
        public String tenantID { get; set; }
        public DateTime RentFrom { get; set; }
        public DateTime RentTo { get; set; }
        public double discount { get; set; }
        public double rent { get; set; }
        public double commission { get; set; }

        public List<SalesItem> salesitems { get; set; }
        public  bool Equals(contract other)
        {
            if (other == null) return false;
            return (this.contractID.Equals(other.contractID));
        }
        public override string ToString()
        {
            return " contractID: " + contractID +
                 " showcaseID: " + showcaseID +
                  " tenantID: " + tenantID +
                   " From: " + RentFrom +
                    " To: " + RentTo +
                     " discount: " + discount +
                      " commission: " + commission;
        }

        public double getAmountdue()
        {
            return rent * (1 - discount);
        }
    }
}
