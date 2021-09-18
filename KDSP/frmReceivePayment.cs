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
    public partial class frmReceivePayment : Form
    {
        public frmReceivePayment()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmReceivePayment_Load(object sender, EventArgs e)
        {
            cmbPatient.DataSource = PatientDAL.GetAllPatients();
        }
        private void LoadAppointmentsByPatient()
        {
            var obj = (Patient)cmbPatient.SelectedItem;
            dataGridView1.DataSource = AppointmentDAL.GetAppointmentsByPatient(obj.Id);

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dataGridView1.Columns.Add(btn);
            btn.HeaderText = "Receive Payment";
            btn.Text = "Click Here";
            btn.Name = "btn";
            btn.UseColumnTextForButtonValue = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewColumnCollection col = dataGridView1.Columns;

            int r = e.RowIndex;
            int c = e.ColumnIndex;

            txtAppId.Text = (string)dataGridView1[12, r].Value.ToString();
            txtPatient.Text = (string)dataGridView1[1, r].Value.ToString();
            txtTherapist.Text = (string)dataGridView1[2, r].Value;
            dtAppDate.Value = DateTime.Parse(dataGridView1[3, r].Value.ToString());
            txtTiming.Text = TimeSpan.Parse(dataGridView1[4, r].Value.ToString()) + "->" + TimeSpan.Parse(dataGridView1[5, r].Value.ToString());
            cmbStatus.Text = (string)dataGridView1[10, r].Value;
            cmbTherapy.Text = (string)dataGridView1[6, r].Value;
            cmbPaymentStatus.Text = (string)dataGridView1[11, r].Value;

            if (cmbTherapy.Text == "OT" || cmbTherapy.Text == "PT")
            {
                txtAmount.Text = "500";
            }
            else if (cmbTherapy.Text == "ST")
            {
                txtAmount.Text = "800";
            }
        }

        private void btnAppByPatient_Click(object sender, EventArgs e)
        {
            if (cmbPatient.SelectedItem != null)
            {
   
                LoadAppointmentsByPatient();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AppointmentDAL.ReceivePayment(Int32.Parse(txtAppId.Text), cmbPaymentStatus.Text, Int32.Parse(txtAmount.Text), txtReceipt.Text);
            LoadAppointmentsByPatient();
        }
    }
}
