using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDP_Project.Entity
{
    class branch : IEquatable<branch>
    {

        public branch(String branchid , int showcaseNum,String branchName)
        {
            Branchid = branchid;
            ShowcaseNum = showcaseNum;
            BranchName = branchName;
        }
        public bool Equals(branch other)
        {
            if (other == null) return false;
            return (this.BranchName.Equals(other.BranchName));
        }
        public int ShowcaseNum { get; set; }
        public String Branchid { get; set; }
        public String BranchName { get; set; }
    }
}
