using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_HastaneRandevu
{
    public class Doctor:Person
    {      
        public decimal Salary { get; set; }        
        public override string ToString()
        {
            return FirstName;
        }
    }
}
