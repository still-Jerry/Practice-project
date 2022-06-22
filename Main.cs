using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeautySalon
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void GoToMenuForm_Click(object sender, EventArgs e)
        {
            MenuA Form = new MenuA();
            this.Visible = false;
            Form.ShowDialog();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            WorkWithDB.UpdateBD("BeautySalon_db", "RegistrationVisit", dataGridViewMain);
            dataGridViewMain.Columns[0].Visible = false;
            dataGridViewMain.Columns[1].HeaderText = "Дата";
            dataGridViewMain.Columns[2].HeaderText = "Время";
            dataGridViewMain.Columns[3].HeaderText = "Цена";
            dataGridViewMain.Columns[4].HeaderText = "Клиент";
            dataGridViewMain.Columns[5].HeaderText = "Мастер";
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
