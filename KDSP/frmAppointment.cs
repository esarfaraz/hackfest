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
    public partial class frmAppointment : Form
    {
        public frmAppointment()
        {
            InitializeComponent();
        }

        private void frmAppointment_Load(object sender, EventArgs e)
        {
            LoadListView(ADODAL.GetAppointmentsByTherapist("2"));
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
    }
}
