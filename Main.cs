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

                DataTable VirtualTable = WorkWithDB.TakeFromBD("BeautySalon_db", "Сlient");
                ClientCb.DataSource = VirtualTable;
                ClientCb.DisplayMember = "surname";
                VirtualTable = WorkWithDB.TakeFromBD("BeautySalon_db", "Master");
                MasterCb.DataSource = VirtualTable;
                MasterCb.DisplayMember = "surname";
            }
            else
            {
                AddB.Visible = false;
                EditB.Visible = false;
                DeleteB.Visible = false;
                AdminSpace.Visible = false;

            }
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
            if (ClientCb.Text == "" || MasterCb.Text == "" || PriceField.Text == "" || DateVisitPicker.Text == "" || TimeVisitPicker.Text=="")
            {
                MessageBox.Show("Заполните все пустые поля!");

            }
                //указать диапазон - время работы с 9 до 21
            else if ((DateTime.Today >= DateVisitPicker.Value))
            {
                MessageBox.Show("Нельзя указывать текущие дату и время, либо ранее.");

            }
            else
            {
                OleDbCommand sql = new OleDbCommand("INSERT INTO RegistrationVisit(id, date_visit, time_visit, price, name_client, name_master) VALUES (" +
                        (dataGridViewMain.RowCount + 1) + ", '" + DateVisitPicker.Value + "' , '" + TimeVisitPicker.Value + "', " + Convert.ToInt32(PriceField.Text) + ", '" +
                          ClientCb.Text + "', '" + MasterCb.Text + "')");

                WorkWithDB.FuncInBD("BeautySalon_db", "RegistrationVisit", dataGridViewMain, sql);
                ClearFields();
            }
        }
        private void ClearFields()
        {
            DateVisitPicker.Value = DateTime.Today;
            TimeVisitPicker.Value = DateTime.Today;
            PriceField.Text = "";
            ClientCb.Text = "";
            MasterCb.Text ="";
        }
    }
}
