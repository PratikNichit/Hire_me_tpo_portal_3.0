using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Hire_me_tpo_portal_3._0.Forms
{
    public partial class FormPdfView : Form
    {
        public FormPdfView(string filePath)
        {
            InitializeComponent();
            LoadPdfFile(filePath);
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadPdfFile(string filePath)
        {

        }
    }
}
