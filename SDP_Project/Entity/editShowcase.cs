using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDP_Project.Entity
{
    class editShowcase
    {
        public editShowcase(String showcaseid, int rent,String genre, String category, String branchid)
        {
            Rent = rent;
            showcaseID = showcaseid;
            Genre = genre;
            Category = category;
            Branchid = branchid;
        }

        public int Rent { get; set; }
        public String showcaseID { get; set; }
        public String Genre { get; set; }
        public String Category { get; set; }
        public String Branchid { get; set; }
    }
}
