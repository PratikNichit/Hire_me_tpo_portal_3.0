using FontAwesome.Sharp;
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
    public partial class Card : UserControl
    {

        //fields 
        public int vancancyId;
        public int companyId;
        public Card()
        {
            InitializeComponent();
        }

        [Category("Extra Properties")]
        public string nameOfCompany
        {
            get
            {
                return CompanyName1.Text;
            }
            set
            {
                CompanyName1.Text = value;
            }
        }

        [Category("Extra Properties")]
        public string companyOffering
        {
            get
            {
                return labelOffering.Text;
            }
            set
            {
                labelOffering.Text = value;
            }
        }

        [Category("Extra Properties")]
        public string registrationEndDate
        {
            get
            {
                return labelEndTime.Text;
            }
            set
            {
                labelEndTime.Text = value;
            }
        }

        [Category("Extra Properties")]
        public string status
        {
            get
            {
                return labelAppliedStatus.Text;
            }
            set
            {
                if(value == "Not Applied")
                {
                    labelAppliedStatus.Text = value;
                    labelAppliedStatus.ForeColor = Color.Red;
                }

            }
        }

        [Category("Extra Properties")]
        public string logo
        {
            get
            {
                if(iconStatus.IconChar.ToString() == "ThumbsUp")
                {
                    return "up";
                }

                if (iconStatus.IconChar.ToString() == "ThumbsDown")
                {
                    return "down";
                }

                return iconStatus.IconChar.ToString();
            }
            set
            {
                if(value == "up")
                {
                    iconStatus.IconChar = IconChar.ThumbsUp;
                }
                if(value == "down")
                {
                    iconStatus.IconChar = IconChar.ThumbsDown;
                    iconStatus.ForeColor = Color.Red;
                }

            }
        }

        [Category("Extra Properties")]
        public int Vacancyid
        {
            get
            {
                return vancancyId;
            }
            set
            {
                vancancyId = value;
            }
        }

        [Category("Extra Properties")]
        public int Companyid
        {
            get
            {
                return companyId;
            }
            set
            {
                companyId = value;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
