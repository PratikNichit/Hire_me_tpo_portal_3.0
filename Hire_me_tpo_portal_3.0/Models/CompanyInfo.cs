using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xaml.Schema;

namespace Hire_me_tpo_portal_3._0
{
    public class CompanyInfo
    {
        public int company_id {  get; set; }    
        public string industry_type { get; set; }
        public string name { get; set; }
        public string compay_type {  get; set; }
        public string location { get; set; }
        public int offering_id { get; set; }
        public string company_address { get; set; }
        public string company_email_id {  get; set; }
        public string min_package {  get; set; }
        public string max_package { get; set; }
        public string about {  get; set; }
    }
}
