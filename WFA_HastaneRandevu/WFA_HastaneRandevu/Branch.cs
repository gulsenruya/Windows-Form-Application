using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_HastaneRandevu
{
    public class Branch
    {

        public string BranchName { get; set; }
        public List<Doctor> Doctors;
        //public List<Branch> Branches { get; set; }
        public override string ToString()
        {
            return BranchName;
            //string braches = string.Empty;
            //foreach (Branch branch in Branches)
            //{ 
            //    braches += branch.BranchName;
            //}
            //return braches;
        }
    }
}
