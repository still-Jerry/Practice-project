using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;
namespace BeautySalon
{
    class WorkWithDB
    {
        public static OleDbConnection ConnectBD(string SourceName)
        {
            string ConnectAcces = "Provider= Microsoft.Jet.OLEDB.4.0; Data Source=" + SourceName + ".mdb;";
            OleDbConnection Connectdb = new OleDbConnection(ConnectAcces);

            Connectdb.Open();
            return Connectdb;
        }
        public static void UpdateBD(string SourceName, string TibleName, DataGridView dataGridView )
        {
            try
            {
                OleDbConnection Connectdb = ConnectBD(SourceName);
                DataTable VirtualTable = new DataTable();
                OleDbCommand request1 = new OleDbCommand("SELECT * FROM " + TibleName + ";");
                request1.Connection = Connectdb;
                request1.ExecuteNonQuery();
                OleDbDataAdapter adapt1 = new OleDbDataAdapter(request1);
                adapt1.Fill(VirtualTable);
                dataGridView.DataSource = VirtualTable;

                //dataGridView.Columns[0].Visible = false;

                Connectdb.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }   
        }
        public static void FuncInBD(string SourceName, string TibleName, DataGridView dataGridView, string ColumnNames, string FromObjects,OleDbCommand sql)
        {
            try
            {
                OleDbConnection Connectdb = ConnectBD(SourceName);
                sql.Connection = Connectdb;
                sql.ExecuteNonQuery();
                Connectdb.Close();
                MessageBox.Show("Информация изменена.");
                UpdateBD(SourceName, TibleName, dataGridView);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
      
    }
}
