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


 
 
        private void AddB_Click(object sender, EventArgs e)
        {
            if (SurnameField.Text == "" || NameField.Text == "" || PatronymicField.Text == "" || JobTitleField.Text == "" || WasBornPicker.Text==""){
                MessageBox.Show("Заполните все пустые поля!");

            }
            else if ((Convert.ToInt32(DateTime.Today.Year) - Convert.ToInt32(WasBornPicker.Value.Year) <= 13)|| (Convert.ToInt32(DateTime.Today.Year) - Convert.ToInt32(WasBornPicker.Value.Year) >= 150))
            {
                MessageBox.Show("Только лица старше 13 и не старше 150 лет.");
             
            }
            else { 
               OleDbCommand sql = new OleDbCommand("INSERT INTO Master(id, surname, name_master, patronymic, was_born, job_title) VALUES (" +
                        (dataGridViewMaters.RowCount + 1) + ", '" + SurnameField.Text + "' , '" + NameField.Text + "', '" + PatronymicField.Text + "', '" +
                          WasBornPicker.Value + "', '" + JobTitleField.Text + "')");

               WorkWithDB.FuncInBD("BeautySalon_db", "Master", dataGridViewMaters, sql);
               ClearFields();
            }
        }
        private void ClearFields() {
            WasBornPicker.Value = DateTime.Today;
            SurnameField.Text = "";
            NameField.Text = "";
            PatronymicField.Text = "";
            JobTitleField.Text = "";
        }

        private void PatronymicField_KeyPress(object sender, KeyPressEventArgs e)
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

        private void SurnameField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

    
     

    }
}
