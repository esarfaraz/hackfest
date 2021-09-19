
namespace KDSP
{
    partial class frmWaitingList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWaitingList));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Patient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientRegNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TherapyDept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VisitFrequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WLId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAvltoSel = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btnSelToAvl = new System.Windows.Forms.Button();
            this.btnSaveAppointments = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSaveRemarks = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Patient,
            this.PatientName,
            this.PatientRegNo,
            this.TherapyDept,
            this.VisitFrequency,
            this.WLId});
            this.dataGridView1.Location = new System.Drawing.Point(12, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(456, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Patient
            // 
            this.Patient.DataPropertyName = "PId";
            this.Patient.HeaderText = "PatientId";
            this.Patient.Name = "Patient";
            this.Patient.Visible = false;
            // 
            // PatientName
            // 
            this.PatientName.DataPropertyName = "PatientFullName";
            this.PatientName.HeaderText = "Patient Name";
            this.PatientName.Name = "PatientName";
            // 
            // PatientRegNo
            // 
            this.PatientRegNo.DataPropertyName = "PatientRegNo";
            this.PatientRegNo.HeaderText = "Patient Reg No";
            this.PatientRegNo.Name = "PatientRegNo";
            // 
            // TherapyDept
            // 
            this.TherapyDept.DataPropertyName = "TherapyDept";
            this.TherapyDept.HeaderText = "Therapy Dept";
            this.TherapyDept.Name = "TherapyDept";
            // 
            // VisitFrequency
            // 
            this.VisitFrequency.DataPropertyName = "VisitFrequency";
            this.VisitFrequency.HeaderText = "Visit Frequency";
            this.VisitFrequency.Name = "VisitFrequency";
            // 
            // WLId
            // 
            this.WLId.DataPropertyName = "WLId";
            this.WLId.HeaderText = "WL Id";
            this.WLId.Name = "WLId";
            this.WLId.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Patients Awaiting Appointments:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Available Appointments";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(493, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Selected Appointments";
            // 
            // btnAvltoSel
            // 
            this.btnAvltoSel.BackColor = System.Drawing.Color.Yellow;
            this.btnAvltoSel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvltoSel.Location = new System.Drawing.Point(336, 246);
            this.btnAvltoSel.Name = "btnAvltoSel";
            this.btnAvltoSel.Size = new System.Drawing.Size(142, 23);
            this.btnAvltoSel.TabIndex = 6;
            this.btnAvltoSel.Text = "Select Appointment";
            this.btnAvltoSel.UseVisualStyleBackColor = false;
            this.btnAvltoSel.Click += new System.EventHandler(this.btnAvltoSel_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 246);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(313, 95);
            this.listBox1.TabIndex = 7;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(496, 246);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(292, 95);
            this.listBox2.TabIndex = 8;
            // 
            // btnSelToAvl
            // 
            this.btnSelToAvl.BackColor = System.Drawing.Color.Yellow;
            this.btnSelToAvl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelToAvl.Location = new System.Drawing.Point(336, 276);
            this.btnSelToAvl.Name = "btnSelToAvl";
            this.btnSelToAvl.Size = new System.Drawing.Size(142, 23);
            this.btnSelToAvl.TabIndex = 9;
            this.btnSelToAvl.Text = "Revert Appointment";
            this.btnSelToAvl.UseVisualStyleBackColor = false;
            this.btnSelToAvl.Click += new System.EventHandler(this.btnSelToAvl_Click);
            // 
            // btnSaveAppointments
            // 
            this.btnSaveAppointments.BackColor = System.Drawing.Color.LawnGreen;
            this.btnSaveAppointments.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAppointments.Location = new System.Drawing.Point(336, 318);
            this.btnSaveAppointments.Name = "btnSaveAppointments";
            this.btnSaveAppointments.Size = new System.Drawing.Size(142, 23);
            this.btnSaveAppointments.TabIndex = 10;
            this.btnSaveAppointments.Text = "Save &Appointments";
            this.btnSaveAppointments.UseVisualStyleBackColor = false;
            this.btnSaveAppointments.Click += new System.EventHandler(this.btnSaveAppointments_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 361);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Waiting List Remarks:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(149, 358);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(639, 52);
            this.textBox1.TabIndex = 12;
            // 
            // btnSaveRemarks
            // 
            this.btnSaveRemarks.BackColor = System.Drawing.Color.LawnGreen;
            this.btnSaveRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveRemarks.Location = new System.Drawing.Point(160, 444);
            this.btnSaveRemarks.Name = "btnSaveRemarks";
            this.btnSaveRemarks.Size = new System.Drawing.Size(184, 23);
            this.btnSaveRemarks.TabIndex = 13;
            this.btnSaveRemarks.Text = "Save &Remarks";
            this.btnSaveRemarks.UseVisualStyleBackColor = false;
            this.btnSaveRemarks.Click += new System.EventHandler(this.btnSaveRemarks_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Orange;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(496, 444);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(200, 23);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(496, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(261, 207);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // frmWaitingList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 506);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSaveRemarks);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSaveAppointments);
            this.Controls.Add(this.btnSelToAvl);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnAvltoSel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmWaitingList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Waiting List";
            this.Load += new System.EventHandler(this.frmWaitingList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAvltoSel;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btnSelToAvl;
        private System.Windows.Forms.Button btnSaveAppointments;
        private System.Windows.Forms.DataGridViewTextBoxColumn Patient;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientRegNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TherapyDept;
        private System.Windows.Forms.DataGridViewTextBoxColumn VisitFrequency;
        private System.Windows.Forms.DataGridViewTextBoxColumn WLId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSaveRemarks;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}