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


        private void btnRegister_Click(object sender, EventArgs e)
        {
            Patient p = new Patient();
            p.ContactNo = txtContactNo.Text;
            p.DOB = dtDOB.Value;
            p.FatherFullName = txtFatherName.Text;
            p.PatientFullName = txtPatientName.Text;
            p.Sex = rdoF.Checked ? "F" : "M";
            p.Status = "Enrolled";
            p.TherapyDept = rdoOT.Checked ? "OT" : rdoPT.Checked ? "PT" : "ST";

            PatientDAL.SavePatient(p);

            WaitingList wl = new WaitingList();
            wl.PatientId = p.Id;
            wl.Status = "Enrolled";
            WaitingListDAL.SaveWaitingList(wl);

        }

        private void frmAddPatient_Load(object sender, EventArgs e)
        {
            dtDOB.MaxDate = System.DateTime.Now;
        }
    }
}
