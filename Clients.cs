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

        private void SurnameField_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void NameField_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void PhoneNumberField_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 9)
            {
                e.Handled = true;
            }
        }

        private void PatronymicField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void AddB_Click(object sender, EventArgs e)
        {
            if (SurnameField.Text == "" || NameField.Text == "" || PatronymicField.Text == "" || PhoneNumberField.Text == "" || WasBornPicker.Text == "")
            {
                MessageBox.Show("Заполните все пустые поля!");

            }
            else if ((Convert.ToInt32(DateTime.Today.Year) - Convert.ToInt32(WasBornPicker.Value.Year) <= 13) || (Convert.ToInt32(DateTime.Today.Year) - Convert.ToInt32(WasBornPicker.Value.Year) >= 150))
            {
                MessageBox.Show("Только лица старше 13 и не старше 150 лет.");

            }
            else
            {
                OleDbCommand sql = new OleDbCommand("INSERT INTO Сlient(id, surname, name_client, patronymic, phone_number, was_born) VALUES (" +
                         (dataGridViewClients.RowCount + 1) + ", '" + SurnameField.Text + "' , '" + NameField.Text + "', '" + PatronymicField.Text + "', " +
                           Convert.ToInt64(PhoneNumberField.Text) + ", '" + WasBornPicker.Value + "')");

                WorkWithDB.FuncInBD("BeautySalon_db", "Сlient", dataGridViewClients, sql);
                ClearFields();
            }
        }
        private void ClearFields()
        {
            WasBornPicker.Value = DateTime.Today;
            SurnameField.Text = "";
            NameField.Text = "";
            PatronymicField.Text = "";
            PhoneNumberField.Text = "";
        }
    }
}
