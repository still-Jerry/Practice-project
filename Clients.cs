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
    public partial class Clients : Form
    {
        public Clients()
        {
            InitializeComponent();
        }

        private void GoToMenuForm_Click(object sender, EventArgs e)
        {
            MenuA Form = new MenuA();
            this.Visible = false;
            Form.ShowDialog();
        }

        private void Clients_Load(object sender, EventArgs e)
        {
            //WorkWithDB.CloseBD(WorkWithDB.UpdateBD("BeautySalon_db", "Client", dataGridViewClients));
            WorkWithDB.UpdateBD("BeautySalon_db", "Сlient", dataGridViewClients);
            dataGridViewClients.Columns[0].Visible = false;
            dataGridViewClients.Columns[1].HeaderText = "Фамилия";
            dataGridViewClients.Columns[2].HeaderText = "Имя";
            dataGridViewClients.Columns[3].HeaderText = "Отчество";
            dataGridViewClients.Columns[4].HeaderText = "Номер телефона";
            dataGridViewClients.Columns[5].HeaderText = "Дата рождения";

            if (Convert.ToBoolean(Authorization.ActiveUser["status"]))
            {
                AddB.Visible = true;
                EditB.Visible = true;
                DeleteB.Visible = true;
                AdminSpace.Visible = true;
            }
            else {
                AddB.Visible = false;
                EditB.Visible = false;
                DeleteB.Visible = false;
                AdminSpace.Visible = false;

            }
        }
    }
}
