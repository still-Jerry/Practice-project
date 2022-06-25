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
        Boolean CanEdit = false;
        Int32 idDataGrid;
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
            ClearFields();
            if (Convert.ToBoolean(Authorization.ActiveUser["status"]))
            {
                AddB.Visible = true;
                EditB.Visible = true;
                DeleteB.Visible = true;
                AdminSpace.Visible = true;
                dataGridViewClients.Dock = DockStyle.None;

            }
            else {
                AddB.Visible = false;
                EditB.Visible = false;
                DeleteB.Visible = false;
                AdminSpace.Visible = false;
                dataGridViewClients.Dock = DockStyle.Fill;

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
        
        private Boolean CheckInaccuracies()
        {
           if (SurnameField.Text == "" || NameField.Text == "" || PatronymicField.Text == "" || PhoneNumberField.Text == "" || WasBornPicker.Text == "")
            {
                MessageBox.Show("Заполните все пустые поля!");
                return false;

            }
            else if ((Convert.ToInt32(DateTime.Today.Year) - Convert.ToInt32(WasBornPicker.Value.Year)) <= 0)
            {
                MessageBox.Show("Указан будущий или текущий год.");
                return false;
            }
            else if ((Convert.ToInt32(DateTime.Today.Year) - Convert.ToInt32(WasBornPicker.Value.Year) <= 13) || (Convert.ToInt32(DateTime.Today.Year) - Convert.ToInt32(WasBornPicker.Value.Year) >= 150))
            {
                MessageBox.Show("Только лица старше 13 и не старше 150 лет.");
                return false;

            }
            else
            {
                return true;
            }
        }

        private void AddB_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckInaccuracies())
                {
                    OleDbCommand sql = new OleDbCommand("INSERT INTO Сlient(id, surname, name_client, patronymic, phone_number, was_born) VALUES (" +
                             (Convert.ToInt32(dataGridViewClients[0, dataGridViewClients.RowCount - 1].Value) + 1) + ", '" + SurnameField.Text + "' , '" + NameField.Text + "', '" + PatronymicField.Text + "', '" +
                               PhoneNumberField.Text + "', '" + WasBornPicker.Value.Date + "')");

                    WorkWithDB.FuncInBD("BeautySalon_db", "Сlient", dataGridViewClients, sql);
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

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

        private void EditB_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CanEdit)
                {
                    MessageBox.Show("Редактируемая строка не выбрана.");
                   
                }
                else if (CheckInaccuracies())
                {

                    OleDbCommand sql = new OleDbCommand("UPDATE Сlient SET surname='" + SurnameField.Text +
                          "', name_client='" + NameField.Text + "', patronymic='" + PatronymicField.Text +
                          "', phone_number='" + PhoneNumberField.Text + "', was_born='" + WasBornPicker.Value.Date +
                          "' Where id=" + idDataGrid + ";");

                    WorkWithDB.FuncInBD("BeautySalon_db", "Сlient", dataGridViewClients, sql);
                    ClearFields();
                    CanEdit = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void dataGridViewClients_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                SurnameField.Text = Convert.ToString(dataGridViewClients.SelectedRows[0].Cells[1].Value);
                NameField.Text = Convert.ToString(dataGridViewClients.SelectedRows[0].Cells[2].Value);
                PatronymicField.Text = Convert.ToString(dataGridViewClients.SelectedRows[0].Cells[3].Value);
                PhoneNumberField.Text = Convert.ToString(dataGridViewClients.SelectedRows[0].Cells[4].Value);               
                WasBornPicker.Value = Convert.ToDateTime(dataGridViewClients.SelectedRows[0].Cells[5].Value);
                idDataGrid = Convert.ToInt32(Convert.ToInt32(dataGridViewClients.SelectedRows[0].Cells[0].Value));
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
                    OleDbCommand sql = new OleDbCommand("DELETE FROM Сlient WHERE id=" + idDataGrid);
                    WorkWithDB.FuncInBD("BeautySalon_db", "Сlient", dataGridViewClients, sql);
                    ClearFields();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
