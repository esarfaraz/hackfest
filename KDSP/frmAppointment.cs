using KDSPDAL;
using KDSPModels;
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

        string FormMode = "";
        private void frmAppointment_Load(object sender, EventArgs e)
        {
            cmbTherapist.DataSource = TherapistDAL.GetAllTherapists();
            cmbPatient.DataSource = PatientDAL.GetAllPatients();
            //LoadListView(ADODAL.GetAppointmentsByTherapist("2"));
        }

        //private void LoadListView(DataTable dt)
        //{
        //    listView1.View = View.Details;
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbTherapist.SelectedItem != null)
            {
                FormMode = "Therapist";

                LoadAppointmentsByTherapist();
            }
        }

        private void LoadAppointmentsByPatient()
        {
            var obj = (Patient)cmbPatient.SelectedItem;
            dataGridView1.DataSource = AppointmentDAL.GetAppointmentsByPatient(obj.Id);

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dataGridView1.Columns.Add(btn);
            btn.HeaderText = "Edit Appointment";
            btn.Text = "Click Here";
            btn.Name = "btn";
            btn.UseColumnTextForButtonValue = true;
        }
        private void LoadAppointmentsByTherapist()
        {
            var obj = (Therapist)cmbTherapist.SelectedItem;
            dataGridView1.DataSource = AppointmentDAL.GetAppointmentsByTherapist(obj.Id);

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dataGridView1.Columns.Add(btn);
            btn.HeaderText = "Edit Appointment";
            btn.Text = "Click Here";
            btn.Name = "btn";
            btn.UseColumnTextForButtonValue = true;
        }
        private void btnAppByPatient_Click(object sender, EventArgs e)
        {
            if (cmbPatient.SelectedItem != null)
            {
                FormMode = "Patient";
                LoadAppointmentsByPatient();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewColumnCollection col = dataGridView1.Columns;

            int r = e.RowIndex;
            int c = e.ColumnIndex;

            txtAppId.Text = (string)dataGridView1[11, r].Value.ToString();
            txtPatient.Text = (string)dataGridView1[1, r].Value.ToString();
            txtTherapist.Text = (string)dataGridView1[2, r].Value;
            dtAppDate.Value = DateTime.Parse(dataGridView1[3, r].Value.ToString());
            txtTiming.Text = TimeSpan.Parse(dataGridView1[4, r].Value.ToString()) +"->"+ TimeSpan.Parse(dataGridView1[5, r].Value.ToString());
            cmbStatus.Text = (string)dataGridView1[9, r].Value;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdStatus_Click(object sender, EventArgs e)
        {
            AppointmentDAL.UpdateAppointmentStatus(Int32.Parse(txtAppId.Text), cmbStatus.Text);
            if (FormMode == "Patient")
            {
                LoadAppointmentsByPatient();
            }
            else
            {
                LoadAppointmentsByTherapist();
            }
            //dataGridView1.Update();
            //dataGridView1.Refresh();
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
