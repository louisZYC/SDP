using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDP_Project.Entity
{
    public class salesrecord : IEquatable<salesrecord>
    {
       

        public String salesrecordID { get; set; }
        public String staffID { get; set; }
        public DateTime salesdate { get; set; }

        public String branchid { get; set; }

        public List<SalesItem> _salesitems { get; set; }

        public bool Equals(salesrecord other)
        {
            if (other == null) return false;
            return (this.salesrecordID.Equals(other.salesrecordID));
        }
    }
}
