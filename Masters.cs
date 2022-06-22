using System;
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
            dataGridViewMaters.Columns[0].Visible = false;
            dataGridViewMaters.Columns[1].HeaderText = "Фамилия";
            dataGridViewMaters.Columns[2].HeaderText = "Имя";
            dataGridViewMaters.Columns[3].HeaderText = "Отчество";
            dataGridViewMaters.Columns[4].HeaderText = "Дата рождения";
            dataGridViewMaters.Columns[5].HeaderText = "Должность";

            if (Convert.ToBoolean(Authorization.ActiveUser["status"]))
            {
                AddB.Visible = true;
                EditB.Visible = true;
                DeleteB.Visible = true;
                AdminSpace.Visible = true;
            }
            else
            {
                AddB.Visible = false;
                EditB.Visible = false;
                DeleteB.Visible = false;
                AdminSpace.Visible = false;

            }
        }

     

    }
}
