using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_HastaneRandevu
{
    public class Appointment:Patient
    {
        //her bir randevuda bir tane branş secilebilir
        //aynı saatte bir branştan bir doktor seçilebiliyor
        public string Time { get; set; }
        public DateTime DateOfAppointment { get; set; }
        public Branch Branch { get; set; }
        public Doctor Doctor { get; set; }

    }
}
