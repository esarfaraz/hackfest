
namespace KDSP
{
    partial class frmReceivePayment
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
            this.btnAppByPatient = new System.Windows.Forms.Button();
            this.cmbPatient = new System.Windows.Forms.ComboBox();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.patientIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TherapistFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointmentDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Therapy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.therapistIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sessionNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.therapistScheduleIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointmentDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtPatient = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTherapist = new System.Windows.Forms.TextBox();
            this.dtAppDate = new System.Windows.Forms.DateTimePicker();
            this.txtTiming = new System.Windows.Forms.TextBox();
            this.cmbTherapy = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtReceipt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAppId = new System.Windows.Forms.TextBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbPaymentStatus = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAppByPatient
            // 
            this.btnAppByPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppByPatient.Location = new System.Drawing.Point(386, 27);
            this.btnAppByPatient.Name = "btnAppByPatient";
            this.btnAppByPatient.Size = new System.Drawing.Size(219, 23);
            this.btnAppByPatient.TabIndex = 11;
            this.btnAppByPatient.Text = "&Find Appointments By Patient";
            this.btnAppByPatient.UseVisualStyleBackColor = true;
            this.btnAppByPatient.Click += new System.EventHandler(this.btnAppByPatient_Click);
            // 
            // cmbPatient
            // 
            this.cmbPatient.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.patientBindingSource, "Id", true));
            this.cmbPatient.DataSource = this.patientBindingSource;
            this.cmbPatient.DisplayMember = "PatientFullName";
            this.cmbPatient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPatient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbPatient.FormattingEnabled = true;
            this.cmbPatient.Location = new System.Drawing.Point(129, 30);
            this.cmbPatient.Name = "cmbPatient";
            this.cmbPatient.Size = new System.Drawing.Size(201, 21);
            this.cmbPatient.TabIndex = 10;
            this.cmbPatient.ValueMember = "Id";
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataSource = typeof(KDSPModels.Patient);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Select Patient:";
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
            this.Therapy,
            this.therapistIdDataGridViewTextBoxColumn,
            this.sessionNumberDataGridViewTextBoxColumn,
            this.therapistScheduleIdDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.paymentStatusDataGridViewTextBoxColumn,
            this.AppId});
            this.dataGridView1.DataSource = this.appointmentDTOBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(927, 150);
            this.dataGridView1.TabIndex = 12;
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
            // Therapy
            // 
            this.Therapy.DataPropertyName = "Therapy";
            this.Therapy.HeaderText = "Therapy";
            this.Therapy.Name = "Therapy";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Patient Name";
            // 
            // txtPatient
            // 
            this.txtPatient.Location = new System.Drawing.Point(130, 249);
            this.txtPatient.Name = "txtPatient";
            this.txtPatient.Size = new System.Drawing.Size(100, 20);
            this.txtPatient.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(310, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Therapist Name";
            // 
            // txtTherapist
            // 
            this.txtTherapist.Location = new System.Drawing.Point(417, 249);
            this.txtTherapist.Name = "txtTherapist";
            this.txtTherapist.Size = new System.Drawing.Size(100, 20);
            this.txtTherapist.TabIndex = 16;
            // 
            // dtAppDate
            // 
            this.dtAppDate.Location = new System.Drawing.Point(130, 284);
            this.dtAppDate.Name = "dtAppDate";
            this.dtAppDate.Size = new System.Drawing.Size(185, 20);
            this.dtAppDate.TabIndex = 17;
            // 
            // txtTiming
            // 
            this.txtTiming.Location = new System.Drawing.Point(417, 284);
            this.txtTiming.Name = "txtTiming";
            this.txtTiming.Size = new System.Drawing.Size(100, 20);
            this.txtTiming.TabIndex = 18;
            // 
            // cmbTherapy
            // 
            this.cmbTherapy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTherapy.Enabled = false;
            this.cmbTherapy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbTherapy.FormattingEnabled = true;
            this.cmbTherapy.Items.AddRange(new object[] {
            "OT",
            "PT",
            "ST"});
            this.cmbTherapy.Location = new System.Drawing.Point(411, 321);
            this.cmbTherapy.Name = "cmbTherapy";
            this.cmbTherapy.Size = new System.Drawing.Size(97, 21);
            this.cmbTherapy.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 358);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Receive Amount";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(130, 358);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 20);
            this.txtAmount.TabIndex = 22;
            // 
            // txtReceipt
            // 
            this.txtReceipt.Location = new System.Drawing.Point(415, 358);
            this.txtReceipt.Name = "txtReceipt";
            this.txtReceipt.Size = new System.Drawing.Size(100, 20);
            this.txtReceipt.TabIndex = 23;
            this.txtReceipt.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(316, 365);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Receipt No";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Appointment Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 324);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Status";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(317, 321);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Threapy";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(16, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(299, 24);
            this.button1.TabIndex = 28;
            this.button1.Text = "&Receive Payment";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(321, 290);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Timing";
            // 
            // txtAppId
            // 
            this.txtAppId.Location = new System.Drawing.Point(613, 256);
            this.txtAppId.Name = "txtAppId";
            this.txtAppId.Size = new System.Drawing.Size(100, 20);
            this.txtAppId.TabIndex = 30;
            this.txtAppId.Visible = false;
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
            this.cmbStatus.Location = new System.Drawing.Point(130, 324);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(89, 21);
            this.cmbStatus.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(518, 323);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "Payment Status:";
            // 
            // cmbPaymentStatus
            // 
            this.cmbPaymentStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbPaymentStatus.FormattingEnabled = true;
            this.cmbPaymentStatus.Items.AddRange(new object[] {
            "Pending",
            "Paid",
            "Waived",
            "Not Required"});
            this.cmbPaymentStatus.Location = new System.Drawing.Point(613, 317);
            this.cmbPaymentStatus.Name = "cmbPaymentStatus";
            this.cmbPaymentStatus.Size = new System.Drawing.Size(121, 21);
            this.cmbPaymentStatus.TabIndex = 33;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(521, 399);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(195, 23);
            this.btnCancel.TabIndex = 34;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmReceivePayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(951, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cmbPaymentStatus);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.txtAppId);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtReceipt);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbTherapy);
            this.Controls.Add(this.txtTiming);
            this.Controls.Add(this.dtAppDate);
            this.Controls.Add(this.txtTherapist);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPatient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAppByPatient);
            this.Controls.Add(this.cmbPatient);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReceivePayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Receive Payment";
            this.Load += new System.EventHandler(this.frmReceivePayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDTOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAppByPatient;
        private System.Windows.Forms.ComboBox cmbPatient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource appointmentDTOBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPatient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTherapist;
        private System.Windows.Forms.DateTimePicker dtAppDate;
        private System.Windows.Forms.TextBox txtTiming;
        private System.Windows.Forms.ComboBox cmbTherapy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtReceipt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAppId;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TherapistFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointmentDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Therapy;
        private System.Windows.Forms.DataGridViewTextBoxColumn therapistIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sessionNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn therapistScheduleIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppId;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbPaymentStatus;
        private System.Windows.Forms.Button btnCancel;
    }
}