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
        }
    }
}
