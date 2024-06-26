﻿using System;
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
    public partial class ComboBoxWithLabel : UserControl
    {
        public ComboBoxWithLabel()
        {
            InitializeComponent();
        }

        [Category("extra Properties")]
        public string PlaceHolder
        {
            get { return placeholder.Text; }
            set { placeholder.Text = value; }
        }

        [Category("extra Properties")]
        public List<string> ListItems
        {
            get
            {
                List<string> items = new List<string>();
                foreach (var item in combobox.Items)
                {
                    items.Add(item.ToString());
                }
                return items;
            }
            set
            {
                combobox.Items.Clear();
                foreach (var item in value)
                {
                    combobox.Items.Add(item);
                }
            }
        }

        [Category("extra Properties")]
        public string Value
        {
            get
            {
                if (combobox.SelectedItem == null)
                {
                    return " ";
                }
                else
                {
                    return combobox.SelectedItem.ToString();
                }
            }
        }

        [Category("extra Properties")]
        public int selectIndex
        {
            set { combobox.SelectedIndex = value; }
        }
    }
}
