using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDP_Project.Entity
{
   public class Showcase
    {

        public Showcase(String showcaseid, int rent)
        {
            Rent = rent;
            showcaseID = showcaseid;
        }

        public int Rent { get; set; }
        public String showcaseID { get; set; }
    }
}
