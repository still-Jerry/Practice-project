using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeautySalon
{
    class Module
    {
        public static Int32 GetNewIndex(DataGridView dataGridView)
        {
            Random rnd = new Random();
            Int32 NewIndex;
            while (true){
                NewIndex = rnd.Next(0, 999999);
                for (int i = 0; i < dataGridView.RowCount; i++)
                {
                    if (NewIndex == Convert.ToInt32(dataGridView.Rows[i].Cells[0].Value))
                    {
                        continue; 
                    }
                }
                break;
            }
            return NewIndex;
        }
    }
}
