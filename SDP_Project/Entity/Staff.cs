using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SDP_Project.Entity;

namespace SDP_Project
{
    public class Staff
    {
        private String rank;
        private String staffID;
        private String name;
        public Staff()
        {
            rank = "unknown";
            staffID = "unknown";
            name = "unknown";
        }
        public Staff( String staffID, String name,String rank)
        {
            this.rank = rank;
            this.staffID = staffID;
            this.name = name;
        }

        public String getRank() { return rank; }
        public String getStaffID() { return staffID; }
        public String getName() { return name; }

    }
}
