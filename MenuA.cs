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
    public partial class MenuA : Form
    {
        public MenuA()
        {
            InitializeComponent();
        }

        private void GoToMainForm_Click(object sender, EventArgs e)
        {
            Main Form = new Main();
            this.Visible = false;
            Form.ShowDialog();
        }

        private void GoToMastersForm_Click(object sender, EventArgs e)
        {
            Masters Form = new Masters();
            this.Visible = false;
            Form.ShowDialog();
        }

        private void GoToClientsForm_Click(object sender, EventArgs e)
        {   
            Clients Form = new Clients();
            this.Visible = false;
            Form.ShowDialog();
        }

        private void GoToUsersForm_Click(object sender, EventArgs e)
        {
            Users Form = new Users();
            this.Visible = false;
            Form.ShowDialog();
        }

        private void GoToAutorizationForm_Click(object sender, EventArgs e)
        {
            Authorization.ActiveUser.Clear();
            Authorization Form = new Authorization();
            this.Visible = false;
            Form.ShowDialog();
        }

        private void MenuA_Load(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(Authorization.ActiveUser["status"]))
            {
                GoToUsersForm.Visible = true;
               
            }
            else
            {
                GoToUsersForm.Visible = false;

            }
        }

        private void MenuA_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
