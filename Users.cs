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
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        private void GoToMenuForm_Click(object sender, EventArgs e)
        {
            MenuA Form = new MenuA();
            this.Visible = false;
            Form.ShowDialog();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            WorkWithDB.UpdateBD("BeautySalon_db", "Users", dataGridViewUsers);
            dataGridViewUsers.Columns[0].Visible = false;
            dataGridViewUsers.Columns[1].HeaderText = "Имя";
            dataGridViewUsers.Columns[2].HeaderText = "Логин";
            dataGridViewUsers.Columns[3].HeaderText = "Пароль";
            dataGridViewUsers.Columns[4].HeaderText = "Статус";
           
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
