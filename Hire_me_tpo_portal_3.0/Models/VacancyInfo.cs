using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hire_me_tpo_portal_3._0.Models
{
    internal class VacancyInfo
    {
        public int Vacancy_id {  get; set; }
        public string Company_Name { get; set; }
        public string job_location { get; set; }    
        public int no_of_vacancy { get; set; }
        public DateTime registation_start_date {  get; set; }
        public DateTime registation_end_date {  get; set; }
        public double Min_Package {  get; set; }
        public double Max_Package { get; set;}
        public string offerings {  get; set; }
    }
}
