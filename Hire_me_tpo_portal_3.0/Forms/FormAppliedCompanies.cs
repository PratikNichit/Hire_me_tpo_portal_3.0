using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hire_me_tpo_portal_3._0.Forms
{
    public partial class FormAppliedCompanies : Form
    {
        public Users users;
        public Panel panelDesktop;
        public FormAppliedCompanies(Users users, Panel panelDesktop)
        {
            InitializeComponent();
            this.users = users;
            this.panelDesktop = panelDesktop;
        }

        private void FormAppliedCompanies_Load(object sender, EventArgs e)
        {
            loadData();
        }


        public void loadData()
        {
            using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString))
            {
                connection.Open();
                var parameters = new { prn_number = users.key_value };
                var cards = connection.Query<CardData>("hire_me.get_applied_companies", parameters, commandType: CommandType.StoredProcedure);
                cards = cards.ToList();
                foreach (var carddata in cards)
                {
                    Card card = new Card(panelDesktop, users,true);
                    card.companyId = carddata.company_id;
                    card.vancancyId = carddata.vacany_id;
                    card.nameOfCompany = carddata.name;
                    card.companyOffering = carddata.offering;
                    card.registrationEndDate = carddata.registation_end_date;
                    card.status = carddata.status;
                    card.Margin = new Padding(10, 10, 10, 10);
                    if (carddata.status == "Applied")
                    {
                        card.logo = "up";
                    }
                    else
                    {
                        card.logo = "down";
                    }
                    flowDesktopPanel.Controls.Add(card);
                }
            }
        }


    }
}
