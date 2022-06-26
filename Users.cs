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
        Boolean CanEdit = false;
        Int32 idDataGrid;
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
            ClearFields();
            if (Convert.ToBoolean(Authorization.ActiveUser["status"]))
            {
                AddB.Visible = true;
                EditB.Visible = true;
                DeleteB.Visible = true;
                AdminSpace.Visible = true;
                dataGridViewUsers.Dock = DockStyle.None;

            }
            else
            {
                AddB.Visible = false;
                EditB.Visible = false;
                DeleteB.Visible = false;
                AdminSpace.Visible = false;
                dataGridViewUsers.Dock = DockStyle.Fill;


            }
        }

        private void AddB_Click(object sender, EventArgs e)
        {

            try
            {
                if (CheckInaccuracies() && CheckSameness(true))
                {
                    //OleDbCommand sql = new OleDbCommand("INSERT INTO Users(id, user_name, login_name, passwd, status) VALUES (" +
                    //        (idDataGrid+3) + ", '" + NameField.Text + "', " + LoginField.Text + ", '" +
                    //          PasswordField.Text + "', '" + StatusCheck.Checked + "')");

                    OleDbCommand sql = new OleDbCommand("INSERT INTO Users(id, user_name, login_name, passwd, status) VALUES (" +
                             (Module.GetNewIndex(dataGridViewUsers)) + ", '" + NameField.Text + "' , '" + LoginField.Text + "', '" + PasswordField.Text + "', " +
                               StatusCheck.Checked + ");");

                    WorkWithDB.FuncInBD("BeautySalon_db", "Users", dataGridViewUsers, sql);
                    ClearFields();
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);

            }
        }

        private void ClearFields()
        {
            LoginField.Text = "";
            PasswordField.Text = "";
            NameField.Text = "";
            StatusCheck.Checked = false;
        }

        private Boolean CheckSameness(Boolean ad) {
            for (int i = 0; i < dataGridViewUsers.RowCount; i++)
            {
                if (ad)
                {
                    if (LoginField.Text == Convert.ToString(dataGridViewUsers.Rows[i].Cells[2].Value) )
                    {
                        MessageBox.Show("Данный логин уже существует.");
                        return false;
                    }
                }
                else {
                    if (LoginField.Text == Convert.ToString(dataGridViewUsers.Rows[i].Cells[2].Value) && dataGridViewUsers.Rows[i] != dataGridViewUsers.SelectedRows[0])
                    {
                        MessageBox.Show("Данный логин уже существует.");
                        return false;
                    }
                }
            }
            return true;
        }

        private Boolean CheckInaccuracies()
        {
            if (PasswordField.Text == "" || LoginField.Text == "" || NameField.Text == "")
            {
                MessageBox.Show("Заполните все пустые поля!");
                return false;
            }
            else if (PasswordField.Text.Length < 3 || LoginField.Text.Length < 3 || NameField.Text.Length < 3)
            {
                MessageBox.Show("Минимальное количество символов,  в заполняемых полях, =3.");
                return false;
            }
            else if (PasswordField.Text.Length < 8) {
                MessageBox.Show("Минимальное количество символов пароля =8.");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void EditB_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CanEdit)
                {
                    MessageBox.Show("Редактируемая строка не выбрана.");
                  
                }
                else if (CheckInaccuracies() && CheckSameness(false))
                {

                    OleDbCommand sql = new OleDbCommand("UPDATE Users SET user_name='" + NameField.Text +
                          "', login_name='" + LoginField.Text + "', passwd='" + PasswordField.Text +
                          "', status=" + StatusCheck.Checked  + " Where id=" + idDataGrid + ";");

                    WorkWithDB.FuncInBD("BeautySalon_db", "Users", dataGridViewUsers, sql);
                    ClearFields();
                    CanEdit = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void dataGridViewUsers_MouseClick(object sender, MouseEventArgs e)
        {

            try
            {
                NameField.Text = Convert.ToString(dataGridViewUsers.SelectedRows[0].Cells[1].Value);
                LoginField.Text = Convert.ToString(dataGridViewUsers.SelectedRows[0].Cells[2].Value);
                PasswordField.Text = Convert.ToString(dataGridViewUsers.SelectedRows[0].Cells[3].Value);
                idDataGrid = Convert.ToInt32(Convert.ToInt32(dataGridViewUsers.SelectedRows[0].Cells[0].Value));
                CanEdit = true;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);

            }
        }

        private void DeleteB_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы действиетльно хотите безвозвратно удалить строку из БД?", "Сообщение пользователю", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    OleDbCommand sql = new OleDbCommand("DELETE FROM Users WHERE id=" + idDataGrid);
                    WorkWithDB.FuncInBD("BeautySalon_db", "Users", dataGridViewUsers, sql);
                    ClearFields();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void GeneratePasswdB_Click(object sender, EventArgs e)
        {
            PasswordField.Text = GetPass();
        }
        public string GetPass()
        {
            Random rnd = new Random();
            string Password = "";
            string  abc = "qwertyuiopasdfghjklzxcvbnm";
                    abc += abc.ToUpper();
                    abc += "!@3$%&*_-";
                    abc += "0123456789";
            for (int i = 0; i < rnd.Next(8, 20); i++)
            {
                Password += abc[rnd.Next(abc.Length)];
            }
            return Password;
        }

        private void Users_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
