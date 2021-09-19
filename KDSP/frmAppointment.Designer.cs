
namespace KDSP
{
    partial class frmAppointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAppointment));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTherapist = new System.Windows.Forms.ComboBox();
            this.therapistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.cmbPatient = new System.Windows.Forms.ComboBox();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAppByTherapist = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.patientIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TherapistFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointmentDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.therapistIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sessionNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.therapistScheduleIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointmentDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientAppointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAppByPatient = new System.Windows.Forms.Button();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.txtPatient = new System.Windows.Forms.TextBox();
            this.txtTherapist = new System.Windows.Forms.TextBox();
            this.btnUpdStatus = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtAppDate = new System.Windows.Forms.DateTimePicker();
            this.txtTiming = new System.Windows.Forms.TextBox();
            this.txtAppId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.therapistBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientAppointmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Therapist:";
            // 
            // cmbTherapist
            // 
            this.cmbTherapist.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.therapistBindingSource, "Id", true));
            this.cmbTherapist.DataSource = this.therapistBindingSource;
            this.cmbTherapist.DisplayMember = "TherapistFullName";
            this.cmbTherapist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTherapist.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbTherapist.FormattingEnabled = true;
            this.cmbTherapist.Location = new System.Drawing.Point(136, 34);
            this.cmbTherapist.Name = "cmbTherapist";
            this.cmbTherapist.Size = new System.Drawing.Size(201, 21);
            this.cmbTherapist.TabIndex = 2;
            this.cmbTherapist.ValueMember = "Id";
            // 
            // therapistBindingSource
            // 
            this.therapistBindingSource.DataSource = typeof(KDSPModels.Therapist);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select Patient:";
            // 
            // cmbPatient
            // 
            this.cmbPatient.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.patientBindingSource, "Id", true));
            this.cmbPatient.DataSource = this.patientBindingSource;
            this.cmbPatient.DisplayMember = "PatientFullName";
            this.cmbPatient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPatient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbPatient.FormattingEnabled = true;
            this.cmbPatient.Location = new System.Drawing.Point(136, 69);
            this.cmbPatient.Name = "cmbPatient";
            this.cmbPatient.Size = new System.Drawing.Size(201, 21);
            this.cmbPatient.TabIndex = 4;
            this.cmbPatient.ValueMember = "Id";
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataSource = typeof(KDSPModels.Patient);
            // 
            // btnAppByTherapist
            // 
            this.btnAppByTherapist.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppByTherapist.Location = new System.Drawing.Point(343, 37);
            this.btnAppByTherapist.Name = "btnAppByTherapist";
            this.btnAppByTherapist.Size = new System.Drawing.Size(219, 23);
            this.btnAppByTherapist.TabIndex = 5;
            this.btnAppByTherapist.Text = "Find Appointments By Therapist";
            this.btnAppByTherapist.UseVisualStyleBackColor = true;
            this.btnAppByTherapist.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patientIdDataGridViewTextBoxColumn,
            this.PatientFullName,
            this.TherapistFullName,
            this.appointmentDateDataGridViewTextBoxColumn,
            this.StartTime,
            this.EndTime,
            this.therapistIdDataGridViewTextBoxColumn,
            this.sessionNumberDataGridViewTextBoxColumn,
            this.therapistScheduleIdDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.paymentStatusDataGridViewTextBoxColumn,
            this.AppId});
            this.dataGridView1.DataSource = this.appointmentDTOBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(37, 208);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(751, 150);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // patientIdDataGridViewTextBoxColumn
            // 
            this.patientIdDataGridViewTextBoxColumn.DataPropertyName = "PatientId";
            this.patientIdDataGridViewTextBoxColumn.HeaderText = "PatientId";
            this.patientIdDataGridViewTextBoxColumn.Name = "patientIdDataGridViewTextBoxColumn";
            this.patientIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // PatientFullName
            // 
            this.PatientFullName.DataPropertyName = "PatientFullName";
            this.PatientFullName.HeaderText = "PatientFullName";
            this.PatientFullName.Name = "PatientFullName";
            // 
            // TherapistFullName
            // 
            this.TherapistFullName.DataPropertyName = "TherapistFullName";
            this.TherapistFullName.HeaderText = "TherapistFullName";
            this.TherapistFullName.Name = "TherapistFullName";
            // 
            // appointmentDateDataGridViewTextBoxColumn
            // 
            this.appointmentDateDataGridViewTextBoxColumn.DataPropertyName = "AppointmentDate";
            this.appointmentDateDataGridViewTextBoxColumn.HeaderText = "AppointmentDate";
            this.appointmentDateDataGridViewTextBoxColumn.Name = "appointmentDateDataGridViewTextBoxColumn";
            // 
            // StartTime
            // 
            this.StartTime.DataPropertyName = "StartTime";
            this.StartTime.HeaderText = "StartTime";
            this.StartTime.Name = "StartTime";
            // 
            // EndTime
            // 
            this.EndTime.DataPropertyName = "EndTime";
            this.EndTime.HeaderText = "EndTime";
            this.EndTime.Name = "EndTime";
            // 
            // therapistIdDataGridViewTextBoxColumn
            // 
            this.therapistIdDataGridViewTextBoxColumn.DataPropertyName = "TherapistId";
            this.therapistIdDataGridViewTextBoxColumn.HeaderText = "TherapistId";
            this.therapistIdDataGridViewTextBoxColumn.Name = "therapistIdDataGridViewTextBoxColumn";
            this.therapistIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // sessionNumberDataGridViewTextBoxColumn
            // 
            this.sessionNumberDataGridViewTextBoxColumn.DataPropertyName = "SessionNumber";
            this.sessionNumberDataGridViewTextBoxColumn.HeaderText = "SessionNumber";
            this.sessionNumberDataGridViewTextBoxColumn.Name = "sessionNumberDataGridViewTextBoxColumn";
            // 
            // therapistScheduleIdDataGridViewTextBoxColumn
            // 
            this.therapistScheduleIdDataGridViewTextBoxColumn.DataPropertyName = "TherapistScheduleId";
            this.therapistScheduleIdDataGridViewTextBoxColumn.HeaderText = "TherapistScheduleId";
            this.therapistScheduleIdDataGridViewTextBoxColumn.Name = "therapistScheduleIdDataGridViewTextBoxColumn";
            this.therapistScheduleIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // paymentStatusDataGridViewTextBoxColumn
            // 
            this.paymentStatusDataGridViewTextBoxColumn.DataPropertyName = "PaymentStatus";
            this.paymentStatusDataGridViewTextBoxColumn.HeaderText = "PaymentStatus";
            this.paymentStatusDataGridViewTextBoxColumn.Name = "paymentStatusDataGridViewTextBoxColumn";
            // 
            // AppId
            // 
            this.AppId.DataPropertyName = "AppId";
            this.AppId.HeaderText = "AppId";
            this.AppId.Name = "AppId";
            this.AppId.Visible = false;
            // 
            // appointmentDTOBindingSource
            // 
            this.appointmentDTOBindingSource.DataSource = typeof(KDSPModelDTOs.AppointmentDTO);
            // 
            // patientAppointmentBindingSource
            // 
            this.patientAppointmentBindingSource.DataSource = typeof(KDSPModels.PatientAppointment);
            // 
            // btnAppByPatient
            // 
            this.btnAppByPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppByPatient.Location = new System.Drawing.Point(343, 69);
            this.btnAppByPatient.Name = "btnAppByPatient";
            this.btnAppByPatient.Size = new System.Drawing.Size(219, 23);
            this.btnAppByPatient.TabIndex = 8;
            this.btnAppByPatient.Text = "Find Appointments By Patient";
            this.btnAppByPatient.UseVisualStyleBackColor = true;
            this.btnAppByPatient.Click += new System.EventHandler(this.btnAppByPatient_Click);
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Booked",
            "Done",
            "Pending",
            "CancelByPatient",
            "CancelByTherapist",
            "CancelSick",
            "CancelByKDSP",
            "NoShow",
            "AllowCancel"});
            this.cmbStatus.Location = new System.Drawing.Point(631, 390);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(150, 21);
            this.cmbStatus.TabIndex = 9;
            // 
            // txtPatient
            // 
            this.txtPatient.Location = new System.Drawing.Point(37, 392);
            this.txtPatient.Name = "txtPatient";
            this.txtPatient.Size = new System.Drawing.Size(100, 20);
            this.txtPatient.TabIndex = 10;
            // 
            // txtTherapist
            // 
            this.txtTherapist.Location = new System.Drawing.Point(166, 391);
            this.txtTherapist.Name = "txtTherapist";
            this.txtTherapist.Size = new System.Drawing.Size(100, 20);
            this.txtTherapist.TabIndex = 11;
            // 
            // btnUpdStatus
            // 
            this.btnUpdStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdStatus.Location = new System.Drawing.Point(250, 439);
            this.btnUpdStatus.Name = "btnUpdStatus";
            this.btnUpdStatus.Size = new System.Drawing.Size(191, 23);
            this.btnUpdStatus.TabIndex = 12;
            this.btnUpdStatus.Text = "Update Status";
            this.btnUpdStatus.UseVisualStyleBackColor = true;
            this.btnUpdStatus.Click += new System.EventHandler(this.btnUpdStatus_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 376);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Patient Full Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(159, 375);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Therapist Full Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(662, 376);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Status";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // dtAppDate
            // 
            this.dtAppDate.Location = new System.Drawing.Point(290, 390);
            this.dtAppDate.Name = "dtAppDate";
            this.dtAppDate.Size = new System.Drawing.Size(200, 20);
            this.dtAppDate.TabIndex = 16;
            // 
            // txtTiming
            // 
            this.txtTiming.Location = new System.Drawing.Point(496, 390);
            this.txtTiming.Name = "txtTiming";
            this.txtTiming.Size = new System.Drawing.Size(129, 20);
            this.txtTiming.TabIndex = 17;
            // 
            // txtAppId
            // 
            this.txtAppId.Location = new System.Drawing.Point(37, 439);
            this.txtAppId.Name = "txtAppId";
            this.txtAppId.Size = new System.Drawing.Size(100, 20);
            this.txtAppId.TabIndex = 18;
            this.txtAppId.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(288, 374);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Appointment Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(501, 374);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Timing";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(595, 439);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(148, 23);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(568, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 190);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // frmAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(800, 492);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAppId);
            this.Controls.Add(this.txtTiming);
            this.Controls.Add(this.dtAppDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnUpdStatus);
            this.Controls.Add(this.txtTherapist);
            this.Controls.Add(this.txtPatient);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.btnAppByPatient);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAppByTherapist);
            this.Controls.Add(this.cmbPatient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbTherapist);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAppointment";
            this.Text = "Manage Appointments";
            this.Load += new System.EventHandler(this.frmAppointment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.therapistBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientAppointmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTherapist;
        private System.Windows.Forms.BindingSource therapistBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbPatient;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private System.Windows.Forms.Button btnAppByTherapist;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource patientAppointmentBindingSource;
        private System.Windows.Forms.BindingSource appointmentDTOBindingSource;
        private System.Windows.Forms.Button btnAppByPatient;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.TextBox txtPatient;
        private System.Windows.Forms.TextBox txtTherapist;
        private System.Windows.Forms.Button btnUpdStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtAppDate;
        private System.Windows.Forms.TextBox txtTiming;
        private System.Windows.Forms.TextBox txtAppId;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TherapistFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointmentDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn therapistIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sessionNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn therapistScheduleIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}