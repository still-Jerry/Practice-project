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
    public partial class Main : Form
    {
        Boolean CanEdit = false;
        Int32 idDataGrid;

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
            dataGridViewMain.Columns[1].HeaderText = "Дата и время";
            dataGridViewMain.Columns[2].HeaderText = "Цена";
            dataGridViewMain.Columns[3].HeaderText = "Клиент";
            dataGridViewMain.Columns[4].HeaderText = "Мастер";
            
            if (Convert.ToBoolean(Authorization.ActiveUser["status"]))
            {
                AddB.Visible = true;
                EditB.Visible = true;
                DeleteB.Visible = true;
                AdminSpace.Visible = true;

                DataTable VirtualTable = WorkWithDB.TakeFromBD("BeautySalon_db", "Сlient");
                ClientCb.DataSource = VirtualTable;
                ClientCb.DisplayMember = "surname";
                VirtualTable = WorkWithDB.TakeFromBD("BeautySalon_db", "Master");
                MasterCb.DataSource = VirtualTable;
                MasterCb.DisplayMember = "surname";
                dataGridViewMain.Dock = DockStyle.None;
            }
            else
            {
                AddB.Visible = false;
                EditB.Visible = false;
                DeleteB.Visible = false;
                AdminSpace.Visible = false;
                dataGridViewMain.Dock = DockStyle.Fill;

            }
            ClearFields();
        }

        private void PriceField_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 9)
            {
                e.Handled = true;
            }
        }

        private void AddB_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckInaccuracies())
                {
                    OleDbCommand sql = new OleDbCommand("INSERT INTO RegistrationVisit(id, date_time, price, id_client, id_master) VALUES (" +
                            (Convert.ToInt32(dataGridViewMain[0,dataGridViewMain.RowCount - 1].Value)+1) + ", '" + DateTimeVisitPicker.Value + "', " + Convert.ToInt32(PriceField.Text) + ", '" +
                              ClientCb.Text + "', '" + MasterCb.Text + "')");

                    WorkWithDB.FuncInBD("BeautySalon_db", "RegistrationVisit", dataGridViewMain, sql);
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
            DateTimeVisitPicker.Value = DateTime.Today;
            DateTimeVisitPicker.Value = DateTime.Today;
            PriceField.Text = "";
            ClientCb.Text = "";
            MasterCb.Text ="";
        }

        private Boolean CheckInaccuracies()
        {
           if (ClientCb.Text == "" || MasterCb.Text == "" || PriceField.Text == "" || DateTimeVisitPicker.Text == "" || DateTimeVisitPicker.Text == "")
            {
                MessageBox.Show("Заполните все пустые поля!");
                return false;

            }
            //указать диапазон - время работы с 9 до 21
            else if (!((new TimeSpan(9, 0, 0) <= DateTimeVisitPicker.Value.TimeOfDay) && (new TimeSpan(20, 0, 0) >= DateTimeVisitPicker.Value.TimeOfDay)))
            {
                MessageBox.Show("Время записи только с 9:00 до 20:00.");
                return false;

            }
            else if (DateTimeVisitPicker.Value <= DateTime.Today)
            {
                MessageBox.Show("Нельзя производить запись на данную дату.");
                return false;

            }
            else if (DateTimeVisitPicker.Value.DayOfWeek == DayOfWeek.Saturday || DateTimeVisitPicker.Value.DayOfWeek == DayOfWeek.Sunday)
            {
                MessageBox.Show("Указанная дата является выходным днём.");
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
                else if (CheckInaccuracies())
                {

                    OleDbCommand sql = new OleDbCommand("UPDATE RegistrationVisit SET date_time='" + DateTimeVisitPicker.Value +
                          "', price='" + Convert.ToInt32(PriceField.Text) + "', id_client='" + ClientCb.Text +
                          "', id_master='" + MasterCb.Text + "' Where id=" + idDataGrid + ";");

                    WorkWithDB.FuncInBD("BeautySalon_db", "RegistrationVisit", dataGridViewMain, sql);
                    ClearFields();
                    CanEdit = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void dataGridViewMain_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                DateTimeVisitPicker.Value = Convert.ToDateTime(dataGridViewMain.SelectedRows[0].Cells[1].Value);
                PriceField.Text = Convert.ToString(dataGridViewMain.SelectedRows[0].Cells[2].Value);
                ClientCb.Text = Convert.ToString(dataGridViewMain.SelectedRows[0].Cells[3].Value) ;
                MasterCb.Text = Convert.ToString(dataGridViewMain.SelectedRows[0].Cells[4].Value) ;
                idDataGrid = Convert.ToInt32(Convert.ToInt32(dataGridViewMain.SelectedRows[0].Cells[0].Value));
                
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
                    OleDbCommand sql = new OleDbCommand("DELETE FROM RegistrationVisit WHERE id=" + idDataGrid);
                    WorkWithDB.FuncInBD("BeautySalon_db", "RegistrationVisit", dataGridViewMain, sql);
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
