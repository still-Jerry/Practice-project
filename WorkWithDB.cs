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
            try{
                string ConnectAcces = "Provider= Microsoft.Jet.OLEDB.4.0; Data Source=" + SourceName + ".mdb;";
                OleDbConnection Connectdb = new OleDbConnection(ConnectAcces);

                Connectdb.Open();
                return Connectdb;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }   
        }
        public static void CloseBD(OleDbConnection Connectdb)
        {
            try
            {
            Connectdb.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }   
        }
        public static OleDbConnection UpdateBD(string SourceName, string TibleName, DataGridView dataGridView)
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
               
                return Connectdb;
                //dataGridView.Columns[0].Visible = false;

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }   
        }
        public static DataTable TakeFromBD(string SourceName, string TibleName)
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
                Connectdb.Close();
                return VirtualTable;
                //dataGridView.Columns[0].Visible = false;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public static OleDbConnection FuncInBD(string SourceName, string TibleName, DataGridView dataGridView, string ColumnNames, string FromObjects, OleDbCommand sql)
        {
            try
            {
                OleDbConnection Connectdb = ConnectBD(SourceName);
                sql.Connection = Connectdb;
                sql.ExecuteNonQuery();
                Connectdb.Close();
                MessageBox.Show("Информация изменена.");
                return UpdateBD(SourceName, TibleName, dataGridView);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
      
    }
}
