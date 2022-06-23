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

        private void AddB_Click(object sender, EventArgs e)
        {

            if (PasswordField.Text == "" || LoginField.Text == "" || NameField.Text == "")
            {
                MessageBox.Show("Заполните все пустые поля!");

            }
                //Проверка на наличеи схожего имени или логина
            //else if ((Convert.ToInt32(DateTime.Today.Year) - Convert.ToInt32(WasBornPicker.Value.Year) <= 13) || (Convert.ToInt32(DateTime.Today.Year) - Convert.ToInt32(WasBornPicker.Value.Year) >= 150))
            //{
            //    MessageBox.Show("Только лица старше 13 и не старше 150 лет.");

            //}
            else
            {
                OleDbCommand sql = new OleDbCommand("INSERT INTO Users(id, user_name, login_name, passwd, status) VALUES (" +
                         (dataGridViewUsers.RowCount + 1) + ", '" + NameField.Text + "' , '" + LoginField.Text + "', '" + PasswordField.Text + "', " +
                           StatusCheck.Checked + ")");

                WorkWithDB.FuncInBD("BeautySalon_db", "Users", dataGridViewUsers, sql);
                ClearFields();
            }
        }
        private void ClearFields()
        {
            LoginField.Text = "";
            PasswordField.Text = "";
            NameField.Text = "";
            StatusCheck.Checked = false;
        }
    }
}
