using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;

namespace Hire_me_tpo_portal_3._0.Models
{
    internal class VacancyDataForCard
    {
       public string company_name {  get; set; }
       public string job_location {  get; set; }
       public int no_of_vacancy { get; set; }
        public DateTime registation_start_date { get; set; }
        public DateTime registation_end_date { get; set; }
        public string min_package {  get; set; }
        public string max_package { get; set;}
        public string offerings { get; set; }
        public string dead_backlogs { get; set; }
        public string current_backlogs { get; set; }
        public string year_down { get; set; }
        public string pursuing_internship { get; set; }
        public string candidate_type { get; set; }
        public string stipend_amound { get; set; }
        public double min_cgpa {  get; set; }
        public double min_ssc_percentage { get; set; }
        public double min_hsc_percentage { get; set; }
        public double min_diploma_percentage { get; set; }
        public string computer_science { get; set; }
        public string information_technology {  get; set; }
        public string Artificial_Intelligence_and_Data_Science { get; set; }
        public string Artificial_Intelligence_and_machine_learning { get; set; }
        public string electronics_and_telecommunication { get; set; }
        public string instrumentation {  get; set; }
        public string production { get; set; }
        public string chemical { get; set; }
        public string file_path { get; set; }

    }
}
