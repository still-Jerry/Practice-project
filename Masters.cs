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
        Boolean CanEdit = false;
        Int32 idDataGrid;
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
            ClearFields();
            if (Convert.ToBoolean(Authorization.ActiveUser["status"]))
            {
                AddB.Visible = true;
                EditB.Visible = true;
                DeleteB.Visible = true;
                AdminSpace.Visible = true;
                dataGridViewMaters.Dock = DockStyle.None;

            }
            else
            {
                AddB.Visible = false;
                EditB.Visible = false;
                DeleteB.Visible = false;
                AdminSpace.Visible = false;
                dataGridViewMaters.Dock = DockStyle.Fill;

            }
        }

        private void AddB_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckInaccuracies())
                {
                    OleDbCommand sql = new OleDbCommand("INSERT INTO Master(id, surname, name_master, patronymic, was_born, job_title) VALUES (" +
                              (Module.GetNewIndex(dataGridViewMaters)) + ", '" + SurnameField.Text + "' , '" + NameField.Text + "', '" + PatronymicField.Text + "', '" +
                               WasBornPicker.Value + "', '" + JobTitleField.Text + "');");

                    WorkWithDB.FuncInBD("BeautySalon_db", "Master", dataGridViewMaters, sql);
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private Boolean CheckInaccuracies() {
            if (SurnameField.Text == "" || NameField.Text == "" || PatronymicField.Text == "" || JobTitleField.Text == "" || WasBornPicker.Text == "")
            {
                MessageBox.Show("Заполните все пустые поля!");
                return false;

            }else if((Convert.ToInt32(DateTime.Today.Year) - Convert.ToInt32(WasBornPicker.Value.Year))<=0){
            MessageBox.Show("Указан будущий или текущий год.");
                return false;
            }
            else if ((Convert.ToInt32(DateTime.Today.Year) - Convert.ToInt32(WasBornPicker.Value.Year) <= 13) || (Convert.ToInt32(DateTime.Today.Year) - Convert.ToInt32(WasBornPicker.Value.Year) >= 150))
            {
                MessageBox.Show("Только лица старше 13 и не старше 150 лет.");
                return false;

            }
            else {
                return true;
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

                    OleDbCommand sql = new OleDbCommand("UPDATE Master SET surname='" + SurnameField.Text +
                          "', name_master='" + NameField.Text + "', patronymic='" + PatronymicField.Text +
                          "', was_born='" + WasBornPicker.Value + "', job_title='" + JobTitleField.Text +
                          "' Where id=" + idDataGrid + ";");

                    WorkWithDB.FuncInBD("BeautySalon_db", "Master", dataGridViewMaters, sql);
                    ClearFields();
                    CanEdit = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
  
        private void dataGridViewMaters_MouseClick(object sender, MouseEventArgs e)
        {

            try
            {
                SurnameField.Text = Convert.ToString(dataGridViewMaters.SelectedRows[0].Cells[1].Value);
                NameField.Text = Convert.ToString(dataGridViewMaters.SelectedRows[0].Cells[2].Value);
                PatronymicField.Text = Convert.ToString(dataGridViewMaters.SelectedRows[0].Cells[3].Value);
                WasBornPicker.Value = Convert.ToDateTime(dataGridViewMaters.SelectedRows[0].Cells[4].Value);
                JobTitleField.Text = Convert.ToString(dataGridViewMaters.SelectedRows[0].Cells[5].Value);
                idDataGrid = Convert.ToInt32(Convert.ToInt32(dataGridViewMaters.SelectedRows[0].Cells[0].Value));
                CanEdit = true;
            }
            catch (Exception ex) {
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
                    OleDbCommand sql = new OleDbCommand("DELETE FROM Master WHERE id=" + idDataGrid);
                    WorkWithDB.FuncInBD("BeautySalon_db", "Master", dataGridViewMaters, sql);
                    ClearFields();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void JobTitleField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void Masters_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
