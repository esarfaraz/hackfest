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
    public partial class MDIParent1 : Form
    {
        private int childFormNumber = 0;

        public MDIParent1()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            frmAddPatient childForm = new frmAddPatient();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }


        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void AddPatientMenu_Click(object sender, EventArgs e)
        {
            frmAddPatient childForm = new frmAddPatient();
            childForm.MdiParent = this;
            childForm.Text = "Add Patient";
            childForm.Show();
            //childForm.showdialog(this.MdiParent);
        }

        private void AddTherapistMenu_Click(object sender, EventArgs e)
        {
            frmAddTherapist childForm = new frmAddTherapist();
            childForm.MdiParent = this;
            childForm.Text = "Add Therapist";
            childForm.Show();
        }

        private void WaitingListMenu_Click(object sender, EventArgs e)
        {
            frmWaitingList childForm = new frmWaitingList();
            childForm.MdiParent = this;
            childForm.Text = "Manage Waiting List";
            childForm.Show();
        }

        private void MngTherapistMenu_Click(object sender, EventArgs e)
        {
            frmAppointment childForm = new frmAppointment();
            childForm.MdiParent = this;
            childForm.Text = "Manage Appointments";
            childForm.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmReceivePayment childForm = new frmReceivePayment();
            childForm.MdiParent = this;
            childForm.Text = "Receive Payment";
            childForm.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmAppointment childForm = new frmAppointment();
            childForm.MdiParent = this;
            childForm.Text = "Manage Appointments";
            childForm.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmAppointment childForm = new frmAppointment();
            childForm.MdiParent = this;
            childForm.Text = "Manage Appointments";
            childForm.Show();
        }
    }
}
