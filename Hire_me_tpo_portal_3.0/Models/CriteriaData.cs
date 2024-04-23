using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hire_me_tpo_portal_3._0.Models
{
    internal class CriteriaData
    {
        public string prn_number { get; set; }
        public double scc_percentage { get; set; }
        public double hsc_percentage { get; set; }
        public double diploma_percentage { get; set; }
        public double current_cgpa { get; set; }
        public string gender { get; set; }
        public int profile_status { get; set; }
        public int is_seda { get; set; }
        public int current_backlog { get; set; }
        public int dead_backlog {  get; set; }
        public int pursing_internship {  get; set; }
    }
}
