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
    public partial class frmAddPatient : Form
    {
        public frmAddPatient()
        {
            InitializeComponent();
        }

        string FormMode = "New";
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                Patient p = new Patient();
                p.ContactNo = txtContactNo.Text;
                p.DOB = dtDOB.Value;
                p.FatherFullName = txtFatherName.Text;
                p.PatientFullName = txtPatientName.Text;
                p.Sex = rdoF.Checked ? "F" : "M";
                p.Status = "Enrolled";
                p.VisitFrequency = cmbVisitFreq.SelectedItem.ToString();
                p.TherapyDept = rdoOT.Checked ? "OT" : rdoPT.Checked ? "PT" : "ST";

                PatientDAL.SavePatient(p);

                WaitingList wl = new WaitingList();
                wl.PatientId = p.Id;
                wl.Status = "Waiting";
                WaitingListDAL.SaveWaitingList(wl);

                MessageBox.Show("Patient enrolled successfully. You can now proceed to Waiting List.");
                this.Close();
            }
        }

        private void frmAddPatient_Load(object sender, EventArgs e)
        {
            dtDOB.MaxDate = System.DateTime.Now;
            cmbVisitFreq.SelectedIndex = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPatientName_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtPatientName.Text))
            {
                e.Cancel = true;
                txtPatientName.Focus();
                errorProvider1.SetError(txtPatientName, "Please enter Patient full name.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPatientName, "");
            }
        }

        private void dtDOB_Validating(object sender, CancelEventArgs e)
        {
            if (dtDOB.Value < DateTime.Now.AddMonths(-78))
            {
                e.Cancel = true;
                dtDOB.Focus();
                errorProvider1.SetError(dtDOB, "Child needs to be 6.5 years or younger.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(dtDOB, "");
            }
        }
    }
}
