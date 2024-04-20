using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hire_me_tpo_portal_3._0
{
    public class PersonalData
    {
      public  long prn_number {  get; set; }
      public string first_name {  get; set; }
      public string middle_name {  get; set; }
      public string last_name { get; set; }
      public string branch_name {  get; set; }
      public int gender { get; set; }
      public DateTime birth_date {  get; set; }
      public string nationality {  get; set; }
      public long contact_no {  get; set; }
      public int is_seda {  get; set; }
      public string current_address { get; set; }
      public string permanent_address{ get; set;}
      public string personal_email_id {  get; set; }
      public long alternate_contact_no { get; set; }
      public long adhar_card_no {  get; set; }
      public string pan_card_no { get; set;}
      public int pursuing_year {  get; set; }
      public int current_backlog {  get; set; }
      public int dead_backlog { get; set; }
      public float current_cgpa {  get; set; }
      public int pursing_internship {  get; set; }
      public int is_placed {  get; set; }


    }
}
