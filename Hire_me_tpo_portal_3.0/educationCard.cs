using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hire_me_tpo_portal_3._0
{
    public partial class educationCard : UserControl
    {

        [Category("Extra Properties")]
        public educationCard()
        {
            InitializeComponent();
        }

        [Category("Extra Properties")]
        public string education
        {
            get { return Education.Text; }
            set { Education.Text = value;}
        }
        
        [Category("Extra Properties")]
        public string university
        {
            get { return University.Text; }
            set { University.Text = value; }
        }

        [Category("Extra Properties")]
        public string institueName
        {
            get { return InstitueName.Text; }
            set { InstitueName.Text = value; }
        }

        [Category("Extra Properties")]
        public float percentage
        {            
            get { 
                  if(Percentage.Text == "")
                  { 
                    return 0;
                  }
                return float.Parse(Percentage.Text);
            }
            set { Percentage.Text = value.ToString();}
        }

        [Category("Extra Properties")]
        public int passingYear
        {
            get { 
                   if(PassingYear.Text == "")
                   {
                    return 0;
                   }
                return int.Parse(PassingYear.Text);
            }
            set { PassingYear.Text = value.ToString();}
        }
    }
    
}
