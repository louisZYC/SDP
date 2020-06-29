using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDP_Project.Entity
{
    public class tenant : IEquatable<tenant>
    {
        public String tenantid { get; set; }

        public String name { get; set; }

        public int phonenumber { get; set; }

        public decimal prepaid { get; set; }


        public bool Equals(tenant other)
        {
            if (other == null) return false;
            return (this.tenantid.Equals(other.tenantid));
        }
    }

}
