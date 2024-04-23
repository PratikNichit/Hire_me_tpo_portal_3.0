using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hire_me_tpo_portal_3._0.Models
{
    internal class ApplicationData
    {
        public int vacany_id {  get; set; }
        public int application_id {  get; set; }
        public long prn_number {  get; set; }
        public string student_name { get; set; }    
        public string date_applied { get; set; }
        public string personal_email_id { get; set; }
    }
}
