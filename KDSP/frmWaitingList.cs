using KDSPDAL;
using KDSPModelDTOs;
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
        string PatientId, WaitingListId=null;
        public frmWaitingList()
        {
            InitializeComponent();
        }

        private void frmWaitingList_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ADODAL.GetPatientWaitings();
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dataGridView1.Columns.Add(btn);
            btn.HeaderText = "Assign Appointment";
            btn.Text = "Click Here";
            btn.Name = "btn";
            btn.UseColumnTextForButtonValue = true;

            //LoadListView(ADODAL.GetPatientWaitings());
        }

        private void LoadListBox(DataTable dt)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                string s = dr["ScheduleDate"].ToString();
                s = s.Substring(0,s.IndexOf(" "));
                string st = dr["StartTime"].ToString();
                st = st.Substring(0, st.IndexOf(":", 3));
                string et = dr["EndTime"].ToString();
                et = et.Substring(0, et.IndexOf(":", 3));
                
                listBox1.Items.Add(dr["TherapistFullName"].ToString() +":"+s +"("+ st +"->"+et +")");

                
            }

        }
        //private void LoadListView(DataTable dt)
        //{
        //    listView1.View = View.Details;
        //    listView1.GridLines = true;
        //    listView1.Columns.Add("TherapistFullName");
        //    listView1.Columns.Add("ScheduleDate");
        //    listView1.Columns.Add("StartTime");
        //    listView1.Columns.Add("EndTime");
        //    //listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
        //    for (int i = 0; i < dt.Rows.Count; i++)
        //    {
        //        DataRow dr = dt.Rows[i];
        //        ListViewItem listitem = new ListViewItem(dr["TherapistFullName"].ToString());
        //        listitem.SubItems.Add(dr["ScheduleDate"].ToString());
        //        listitem.SubItems.Add(dr["StartTime"].ToString());
        //        listitem.SubItems.Add(dr["EndTime"].ToString());
        //        listView1.Items.Add(listitem);
        //    }
        //    listView1.Refresh();
        //}
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

            PatientId = (string)dataGridView1[1, r].Value.ToString();
            string TherapyType = (string)dataGridView1[4, r].Value;
            WaitingListId = (string)dataGridView1[6, r].Value.ToString();

            listBox1.Items.Clear();
            listBox2.Items.Clear();
            //LoadListView(ADODAL.GetAppointments(TherapyType));
            LoadListBox(ADODAL.GetAppointments(TherapyType));
        }



        //private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (listView1.SelectedItems.Count > 0)
        //    {
        //        ListViewItem item = listView1.SelectedItems[0];
        //        if (listView2.Items.Count == 0)
        //        {
        //            listView2.View = View.Details;
        //            listView2.GridLines = true;
        //            listView2.Columns.Add("TherapistFullName");
        //            listView2.Columns.Add("ScheduleDate");
        //            listView2.Columns.Add("StartTime");
        //            listView2.Columns.Add("EndTime");
        //        }
        //        ListViewItem listitem = new ListViewItem(item.SubItems[0].Text);
        //        listitem.SubItems.Add(item.SubItems[1].Text);
        //        listitem.SubItems.Add(item.SubItems[2].Text);
        //        listitem.SubItems.Add(item.SubItems[3].Text);
        //        listView2.Items.Add(listitem);

        //    }

    //}


    private void btnAvltoSel_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                listBox2.Items.Add(listBox1.SelectedItem);
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private void btnSaveAppointments_Click(object sender, EventArgs e)
        {
            if (listBox2.Items.Count > 0)
            {
                List<BookAppointmentDTO> lst = new List<BookAppointmentDTO>();
                foreach (var item in listBox2.Items)
                {
                    string data = item.ToString();
                    BookAppointmentDTO ba = new BookAppointmentDTO();
                    ba.PatientId = Int32.Parse(PatientId);
                    ba.TherapistName = data.Substring(0, data.IndexOf(":"));
                    ba.ScheduleDate = DateTime.Parse(data.Substring(data.IndexOf(":") + 1, data.IndexOf("(") - data.IndexOf(":") - 1));
                    ba.StartTime = TimeSpan.Parse(data.Substring(data.IndexOf("(") + 1, data.IndexOf("->") - data.IndexOf("(") - 1));
                    ba.EndTime = TimeSpan.Parse(data.Substring(data.IndexOf("->") + 2, data.IndexOf(")") - data.IndexOf("->") - 2));
                    ba.WaitingListId = Int32.Parse(WaitingListId);
                    ba.SessionNumber = 1;
                    lst.Add(ba);
                }

                lst = lst.OrderBy(x => x.ScheduleDate).OrderBy(y => y.StartTime).ToList();

                AppointmentDAL.SaveBookAppointment(lst);
                WaitingListDAL.UpdateWaitingListToBooked(Int32.Parse(WaitingListId));
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveRemarks_Click(object sender, EventArgs e)
        {
            if (WaitingListId != null)
            {
                WaitingListDAL.UpdateWaitingListRemarks(Int32.Parse(WaitingListId), textBox1.Text);
            }
        }

        private void btnSelToAvl_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex >= 0)
            {
                listBox1.Items.Add(listBox2.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
        }

    }
}
