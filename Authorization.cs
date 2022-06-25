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
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        public static Dictionary<string, string> ActiveUser = new Dictionary<string, string>();
        DataTable VirtualTable = WorkWithDB.TakeFromBD("BeautySalon_db", "Users");

        //public static Dictionary<string, string> ActiveUser = new Dictionary<string, string>();
        private void Authorization_Load(object sender, EventArgs e)
        {

            UsersNameCb.DataSource = VirtualTable;
            UsersNameCb.DisplayMember = "user_name";// столбец для отображения
            UsersNameCb.Text = "";
        }

        private void UsersNameCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActiveUser.Clear();
            int id = UsersNameCb.SelectedIndex;
            ActiveUser.Add("user_name", Convert.ToString(VirtualTable.Rows[id][1]));
            ActiveUser.Add("login_name",Convert.ToString(VirtualTable.Rows[id][2]));
            ActiveUser.Add("passwd", Convert.ToString(VirtualTable.Rows[id][3]));
            ActiveUser.Add("status", Convert.ToString(VirtualTable.Rows[id][4]));

        }

        private void EntranceB_Click(object sender, EventArgs e)
        {
            if (PasswordField.Text == String.Empty || UsersNameCb.Text == String.Empty)
            {
                MessageBox.Show("Заполните все поля.");
            
            }
            else if (PasswordField.Text == ActiveUser["passwd"] && UsersNameCb.Text == ActiveUser["user_name"])
            {
                MenuA Form = new MenuA();
                this.Visible = false;
                Form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Пароль не совпадает.");
                PasswordField.Text = "";
            }
        }
    }
}
