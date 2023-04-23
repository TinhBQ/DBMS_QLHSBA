using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Staff
{
    public partial class TrangChu : Form
    {
        private List<myQueue> myQueues = new List<myQueue>();

        public TrangChu()
        {
            InitializeComponent();
        }

        public void loadTable()
        {
            dataGridViewIndex.Rows.Clear();

            foreach (var item in myQueues)
            {
                int index = dataGridViewIndex.Rows.Add();
                dataGridViewIndex.Rows[index].Cells[0].Value = item.index;
                dataGridViewIndex.Rows[index].Cells[1].Value = item.dateTime.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            myQueue queue = new myQueue();
            if (myQueues.Count > 0)
            {
                queue.index = myQueues.LastOrDefault().index + 1;
            }
            else
            {
                queue.index = 1;
            }
            queue.dateTime = DateTime.Now;

            myQueues.Add(queue);
            loadTable();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            delete();
        }

        public void delete()
        {
            int rowIndex = (int)dataGridViewIndex.Rows[0].Cells[0].Value;
            int index = myQueues.FindIndex(item => item.index == rowIndex);
            myQueues.RemoveAt(index);

            loadTable();
        }

        private void TrangChu_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridViewIndex_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            delete();
        }
    }

    public class myQueue
    {
        public int index { get; set; }
        public DateTime dateTime { get; set; }
    }
}
