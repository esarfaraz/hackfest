
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIParent1));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.PatientMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AddPatientMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.TherapistMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AddTherapistMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.AppointmentMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.WaitingListMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.MngTherapistMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
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
            this.toolStripMenuItem9,
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
            this.PatientMenu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientMenu.Name = "PatientMenu";
            this.PatientMenu.Size = new System.Drawing.Size(64, 20);
            this.PatientMenu.Text = "&Patients";
            // 
            // AddPatientMenu
            // 
            this.AddPatientMenu.Name = "AddPatientMenu";
            this.AddPatientMenu.Size = new System.Drawing.Size(238, 22);
            this.AddPatientMenu.Text = "Add Patient";
            this.AddPatientMenu.Click += new System.EventHandler(this.AddPatientMenu_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(238, 22);
            this.toolStripMenuItem3.Text = "Manage Patient Appointment";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(238, 22);
            this.toolStripMenuItem4.Text = "Manage Patient";
            // 
            // TherapistMenu
            // 
            this.TherapistMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddTherapistMenu,
            this.toolStripMenuItem2,
            this.toolStripMenuItem5});
            this.TherapistMenu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TherapistMenu.Name = "TherapistMenu";
            this.TherapistMenu.Size = new System.Drawing.Size(76, 20);
            this.TherapistMenu.Text = "Therapists";
            // 
            // AddTherapistMenu
            // 
            this.AddTherapistMenu.Name = "AddTherapistMenu";
            this.AddTherapistMenu.Size = new System.Drawing.Size(227, 22);
            this.AddTherapistMenu.Text = "Add Therapist";
            this.AddTherapistMenu.Click += new System.EventHandler(this.AddTherapistMenu_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(227, 22);
            this.toolStripMenuItem2.Text = "Manage Therapist Schedule";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(227, 22);
            this.toolStripMenuItem5.Text = "Manage Therapist";
            // 
            // AppointmentMenu
            // 
            this.AppointmentMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WaitingListMenu,
            this.MngTherapistMenu,
            this.toolStripMenuItem1});
            this.AppointmentMenu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppointmentMenu.Name = "AppointmentMenu";
            this.AppointmentMenu.Size = new System.Drawing.Size(98, 20);
            this.AppointmentMenu.Text = "Appointments";
            // 
            // WaitingListMenu
            // 
            this.WaitingListMenu.Name = "WaitingListMenu";
            this.WaitingListMenu.Size = new System.Drawing.Size(200, 22);
            this.WaitingListMenu.Text = "Waiting List";
            this.WaitingListMenu.Click += new System.EventHandler(this.WaitingListMenu_Click);
            // 
            // MngTherapistMenu
            // 
            this.MngTherapistMenu.Name = "MngTherapistMenu";
            this.MngTherapistMenu.Size = new System.Drawing.Size(200, 22);
            this.MngTherapistMenu.Text = "Manage Appointments";
            this.MngTherapistMenu.Click += new System.EventHandler(this.MngTherapistMenu_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(200, 22);
            this.toolStripMenuItem1.Text = "Receive Payment";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem7,
            this.toolStripMenuItem8});
            this.toolStripMenuItem6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(95, 20);
            this.toolStripMenuItem6.Text = "Configuration";
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(213, 22);
            this.toolStripMenuItem7.Text = "Manage Calendar";
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(213, 22);
            this.toolStripMenuItem8.Text = "Manage Therapy Charges";
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
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(63, 20);
            this.toolStripMenuItem9.Text = "Reports";
            // 
            // MDIParent1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MDIParent1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KDSP Patient Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
    }
}



