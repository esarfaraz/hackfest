
namespace KDSP
{
    partial class MDIParent1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.PatientMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AddPatientMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.TherapistMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AddTherapistMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AppointmentMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.WaitingListMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.MngTherapistMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PatientMenu,
            this.TherapistMenu,
            this.AppointmentMenu,
            this.toolStripMenuItem6});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // PatientMenu
            // 
            this.PatientMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddPatientMenu,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.PatientMenu.Name = "PatientMenu";
            this.PatientMenu.Size = new System.Drawing.Size(61, 20);
            this.PatientMenu.Text = "&Patients";
            // 
            // AddPatientMenu
            // 
            this.AddPatientMenu.Name = "AddPatientMenu";
            this.AddPatientMenu.Size = new System.Drawing.Size(231, 22);
            this.AddPatientMenu.Text = "Add Patient";
            this.AddPatientMenu.Click += new System.EventHandler(this.AddPatientMenu_Click);
            // 
            // TherapistMenu
            // 
            this.TherapistMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddTherapistMenu,
            this.toolStripMenuItem2,
            this.toolStripMenuItem5});
            this.TherapistMenu.Name = "TherapistMenu";
            this.TherapistMenu.Size = new System.Drawing.Size(72, 20);
            this.TherapistMenu.Text = "Therapists";
            // 
            // AddTherapistMenu
            // 
            this.AddTherapistMenu.Name = "AddTherapistMenu";
            this.AddTherapistMenu.Size = new System.Drawing.Size(219, 22);
            this.AddTherapistMenu.Text = "Add Therapist";
            this.AddTherapistMenu.Click += new System.EventHandler(this.AddTherapistMenu_Click);
            // 
            // AppointmentMenu
            // 
            this.AppointmentMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WaitingListMenu,
            this.MngTherapistMenu,
            this.toolStripMenuItem1});
            this.AppointmentMenu.Name = "AppointmentMenu";
            this.AppointmentMenu.Size = new System.Drawing.Size(95, 20);
            this.AppointmentMenu.Text = "Appointments";
            // 
            // WaitingListMenu
            // 
            this.WaitingListMenu.Name = "WaitingListMenu";
            this.WaitingListMenu.Size = new System.Drawing.Size(196, 22);
            this.WaitingListMenu.Text = "Waiting List";
            this.WaitingListMenu.Click += new System.EventHandler(this.WaitingListMenu_Click);
            // 
            // MngTherapistMenu
            // 
            this.MngTherapistMenu.Name = "MngTherapistMenu";
            this.MngTherapistMenu.Size = new System.Drawing.Size(196, 22);
            this.MngTherapistMenu.Text = "Manage Appointments";
            this.MngTherapistMenu.Click += new System.EventHandler(this.MngTherapistMenu_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(632, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(196, 22);
            this.toolStripMenuItem1.Text = "Attend Appointment";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(219, 22);
            this.toolStripMenuItem2.Text = "Manage Therapist Schedule";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(231, 22);
            this.toolStripMenuItem3.Text = "Manage Patient Appointment";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(231, 22);
            this.toolStripMenuItem4.Text = "Manage Patient";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(219, 22);
            this.toolStripMenuItem5.Text = "Manage Therapist";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem7,
            this.toolStripMenuItem8});
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(93, 20);
            this.toolStripMenuItem6.Text = "Configuration";
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(208, 22);
            this.toolStripMenuItem7.Text = "Manage Calendar";
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(208, 22);
            this.toolStripMenuItem8.Text = "Manage Therapy Charges";
            // 
            // MDIParent1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MDIParent1";
            this.Text = "MDIParent1";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem PatientMenu;
        private System.Windows.Forms.ToolStripMenuItem AddPatientMenu;
        private System.Windows.Forms.ToolStripMenuItem TherapistMenu;
        private System.Windows.Forms.ToolStripMenuItem AddTherapistMenu;
        private System.Windows.Forms.ToolStripMenuItem AppointmentMenu;
        private System.Windows.Forms.ToolStripMenuItem WaitingListMenu;
        private System.Windows.Forms.ToolStripMenuItem MngTherapistMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
    }
}



