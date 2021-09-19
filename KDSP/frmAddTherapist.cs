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
    public partial class frmAddTherapist : Form
    {
        string FormMode = "New";
        public frmAddTherapist()
        {
            InitializeComponent();
        }

        private void AddTherapist_Load(object sender, EventArgs e)
        {
            string[] timestring = { "00:00", "01:00", "02:00", "03:00", "04:00", "05:00", "06:00", "07:00", "08:00", "09:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00", "22:00", "23:00" };
            cmbStartTime.Items.AddRange(timestring);
            cmbStartTime.SelectedItem ="09:00";
            cmbEndTime.Items.AddRange(timestring);
            cmbEndTime.SelectedItem = "18:00";
            dtDOB.MaxDate = DateTime.Now.AddYears(-20);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                Therapist p = new Therapist();
                p.ContactNo = txtContactNo.Text;
                p.DOB = dtDOB.Value;
                p.TherapistFullName = txtTherapistName.Text;
                p.Sex = rdoF.Checked ? "F" : "M";
                p.Status = "Active";
                p.OTTherapist = chkOT.Checked ? "Y" : "N";
                p.PTTherapist = chkPT.Checked ? "Y" : "N";
                p.StTherapist = chkST.Checked ? "Y" : "N";
                //p.TherapyDept = rdoOT.Checked ? "OT" : rdoPT.Checked ? "PT" : "ST";
                p.ClinicStartDate = dtClinicStartDate.Value;
                p.ClinicEndDate = dtClinicEndDate.Value;
                p.ShiftStartTime = TimeSpan.Parse(cmbStartTime.SelectedItem.ToString());
                p.ShiftEndTime = TimeSpan.Parse(cmbEndTime.SelectedItem.ToString());
                TherapistDAL.SaveTherapist(p);

                TherapistDAL.GenerateSchedule(p.Id);

                MessageBox.Show("Therapist registered successfully. Therpaist Schedule is generated as well.");

                this.Close();
            }

           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTherapistName_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtTherapistName.Text))
            {
                e.Cancel = true;
                txtTherapistName.Focus();
                errorProvider1.SetError(txtTherapistName, "Please enter Therapist full name.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtTherapistName, "");
            }
        }

        private void btnRegister_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void btnRegister_Validated(object sender, EventArgs e)
        {
            //string[] timestring = { "00:00", "01:00", "02:00", "03:00", "04:00", "05:00", "06:00", "07:00", "08:00", "09:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00", "22:00", "23:00" };
            //int indexStartTime = Array.IndexOf(timestring, cmbStartTime.SelectedIndex.ToString());
            //int indexEndTime = Array.IndexOf(timestring, cmbEndTime.SelectedIndex.ToString());
            //if (!chkOT.Checked && !chkPT.Checked && !chkST.Checked)
            //{
            //    e.Cancel = true;
            //    chkOT.Focus();
            //    errorProvider1.SetError(chkOT, "Please specify Therapy department");
            //}
            //else if (dtClinicStartDate.Value >= dtClinicEndDate.Value)
            //{
            //    e.Cancel = true;
            //    dtClinicStartDate.Focus();
            //    errorProvider1.SetError(dtClinicStartDate, "Clinic start date should be less than Clinic end date.");
            //}
            //else if (indexStartTime >= indexEndTime)
            //{
            //    e.Cancel = true;
            //    cmbStartTime.Focus();
            //    errorProvider1.SetError(dtClinicStartDate, "Shift start time should be less than Shift end time.");
            //}
            //else

            //{
            //    e.Cancel = false;
            //    errorProvider1.SetError(chkOT, "");
            //}
        }

        private void chkOT_Validating(object sender, CancelEventArgs e)
        {
            if (!chkOT.Checked && !chkPT.Checked && !chkST.Checked)
            {
                e.Cancel = true;
                chkOT.Focus();
                errorProvider1.SetError(chkOT, "Please specify Therapy department");
            }
            else

            {
                e.Cancel = false;
                errorProvider1.SetError(chkOT, "");
            }
        }

        private void chkPT_Validating(object sender, CancelEventArgs e)
        {
            //if (!chkOT.Checked && !chkPT.Checked && !chkST.Checked)
            //{
            //    e.Cancel = true;
            //    chkPT.Focus();
            //    errorProvider1.SetError(chkPT, "Please specify Therapy department");
            //}
            //else

            //{
            //    e.Cancel = false;
            //    errorProvider1.SetError(chkPT, "");
            //}
        }

        private void dtClinicEndDate_Validating(object sender, CancelEventArgs e)
        {
            if (dtClinicStartDate.Value >= dtClinicEndDate.Value)
            {
                e.Cancel = true;
                dtClinicEndDate.Focus();
                errorProvider1.SetError(dtClinicEndDate, "Clinic start date should be less than Clinic end date.");
            }
            else

            {
                e.Cancel = false;
                errorProvider1.SetError(dtClinicEndDate, "");
            }
        }

        private void cmbEndTime_Validating(object sender, CancelEventArgs e)
        {
            //string[] timestring = { "00:00", "01:00", "02:00", "03:00", "04:00", "05:00", "06:00", "07:00", "08:00", "09:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00", "22:00", "23:00" };
            //int indexStartTime = Array.IndexOf(timestring, cmbStartTime.SelectedIndex.ToString());
            //int indexEndTime = Array.IndexOf(timestring, cmbEndTime.SelectedIndex.ToString());
            //if (indexStartTime >= indexEndTime)
            //{
            //    e.Cancel = true;
            //    cmbEndTime.Focus();
            //    errorProvider1.SetError(cmbEndTime, "Shift start time should be less than Shift end time.");
            //}
            //else

            //{
            //    e.Cancel = false;
            //    errorProvider1.SetError(cmbEndTime, "");
            //}
        }
    }
}
