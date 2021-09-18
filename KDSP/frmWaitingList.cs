using KDSPDAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KDSP
{
    public partial class frmWaitingList : Form
    {
        public frmWaitingList()
        {
            InitializeComponent();
        }

        private void frmWaitingList_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ADODAL.GetPatientWaitings();
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dataGridView1.Columns.Add(btn);
            btn.HeaderText = "Click Data";
            btn.Text = "Click Here";
            btn.Name = "btn";
            btn.UseColumnTextForButtonValue = true;

            //LoadListView(ADODAL.GetPatientWaitings());
        }

        private void LoadListView(DataTable dt)
        {
            listView1.View = View.Details;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                ListViewItem listitem = new ListViewItem(dr["TherapistFullName"].ToString());
                listitem.SubItems.Add(dr["ScheduleDate"].ToString());
                listitem.SubItems.Add(dr["StartTime"].ToString());
                listitem.SubItems.Add(dr["EndTime"].ToString());
                listView1.Items.Add(listitem);
            }
            listView1.Refresh();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewColumnCollection col =dataGridView1.Columns;

            if (e.ColumnIndex == 3)
            {
                MessageBox.Show((e.RowIndex + 1) + "  Row  " + (e.ColumnIndex + 1) + "  Column button clicked ");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewColumnCollection col = dataGridView1.Columns;

            int r = e.RowIndex;
            int c = e.ColumnIndex;

            string data = (string)dataGridView1[0, r].Value;

            string PId = (string)dataGridView1[1, r].Value.ToString();
            string TherapyType = (string)dataGridView1[4, r].Value;
            string WId = (string)dataGridView1[7, r].Value.ToString();

            LoadListView(ADODAL.GetAppointments(TherapyType));
        }
    }
}
