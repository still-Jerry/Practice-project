﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace BeautySalon
{
    public partial class Masters : Form
    {
        public Masters()
        {
            InitializeComponent(); 
        }

        private void GoToMenuForm_Click(object sender, EventArgs e)
        {
            MenuA Form = new MenuA();
            this.Visible = false;
            Form.ShowDialog();
        }

        private void Masters_Load(object sender, EventArgs e)
        {
            WorkWithDB.UpdateBD("BeautySalon_db", "Master", dataGridViewMaters);
        }

     

    }
}
