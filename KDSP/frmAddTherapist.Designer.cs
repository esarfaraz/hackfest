
namespace KDSP
{
    partial class frmAddTherapist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddTherapist));
            this.btnCancel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtDOB = new System.Windows.Forms.DateTimePicker();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.txtTherapistName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoM = new System.Windows.Forms.RadioButton();
            this.rdoF = new System.Windows.Forms.RadioButton();
            this.dtClinicStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtClinicEndDate = new System.Windows.Forms.DateTimePicker();
            this.cmbStartTime = new System.Windows.Forms.ComboBox();
            this.cmbEndTime = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.chkOT = new System.Windows.Forms.CheckBox();
            this.chkPT = new System.Windows.Forms.CheckBox();
            this.chkST = new System.Windows.Forms.CheckBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(405, 400);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(151, 23);
            this.btnCancel.TabIndex = 30;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Therapy Department:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Date Of Birth:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Gender:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Contact No:";
            // 
            // dtDOB
            // 
            this.dtDOB.Location = new System.Drawing.Point(165, 115);
            this.dtDOB.Name = "dtDOB";
            this.dtDOB.Size = new System.Drawing.Size(200, 20);
            this.dtDOB.TabIndex = 24;
            // 
            // txtContactNo
            // 
            this.txtContactNo.Location = new System.Drawing.Point(165, 55);
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(200, 20);
            this.txtContactNo.TabIndex = 23;
            // 
            // txtTherapistName
            // 
            this.txtTherapistName.Location = new System.Drawing.Point(165, 28);
            this.txtTherapistName.Name = "txtTherapistName";
            this.txtTherapistName.Size = new System.Drawing.Size(200, 20);
            this.txtTherapistName.TabIndex = 21;
            this.txtTherapistName.Validating += new System.ComponentModel.CancelEventHandler(this.txtTherapistName_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Therapist Name:";
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(165, 400);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(176, 23);
            this.btnRegister.TabIndex = 19;
            this.btnRegister.Text = "&Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            this.btnRegister.Validating += new System.ComponentModel.CancelEventHandler(this.btnRegister_Validating);
            this.btnRegister.Validated += new System.EventHandler(this.btnRegister_Validated);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoM);
            this.groupBox1.Controls.Add(this.rdoF);
            this.groupBox1.Location = new System.Drawing.Point(165, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 32);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            // 
            // rdoM
            // 
            this.rdoM.AutoSize = true;
            this.rdoM.Location = new System.Drawing.Point(7, 10);
            this.rdoM.Name = "rdoM";
            this.rdoM.Size = new System.Drawing.Size(48, 17);
            this.rdoM.TabIndex = 2;
            this.rdoM.TabStop = true;
            this.rdoM.Text = "Male";
            this.rdoM.UseVisualStyleBackColor = true;
            // 
            // rdoF
            // 
            this.rdoF.AutoSize = true;
            this.rdoF.Location = new System.Drawing.Point(109, 9);
            this.rdoF.Name = "rdoF";
            this.rdoF.Size = new System.Drawing.Size(59, 17);
            this.rdoF.TabIndex = 1;
            this.rdoF.TabStop = true;
            this.rdoF.Text = "Female";
            this.rdoF.UseVisualStyleBackColor = true;
            // 
            // dtClinicStartDate
            // 
            this.dtClinicStartDate.Location = new System.Drawing.Point(165, 245);
            this.dtClinicStartDate.Name = "dtClinicStartDate";
            this.dtClinicStartDate.Size = new System.Drawing.Size(200, 20);
            this.dtClinicStartDate.TabIndex = 33;
            // 
            // dtClinicEndDate
            // 
            this.dtClinicEndDate.Location = new System.Drawing.Point(165, 281);
            this.dtClinicEndDate.Name = "dtClinicEndDate";
            this.dtClinicEndDate.Size = new System.Drawing.Size(200, 20);
            this.dtClinicEndDate.TabIndex = 34;
            this.dtClinicEndDate.Validating += new System.ComponentModel.CancelEventHandler(this.dtClinicEndDate_Validating);
            // 
            // cmbStartTime
            // 
            this.cmbStartTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStartTime.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbStartTime.FormattingEnabled = true;
            this.cmbStartTime.Location = new System.Drawing.Point(165, 308);
            this.cmbStartTime.Name = "cmbStartTime";
            this.cmbStartTime.Size = new System.Drawing.Size(121, 21);
            this.cmbStartTime.TabIndex = 35;
            // 
            // cmbEndTime
            // 
            this.cmbEndTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEndTime.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbEndTime.FormattingEnabled = true;
            this.cmbEndTime.Location = new System.Drawing.Point(165, 336);
            this.cmbEndTime.Name = "cmbEndTime";
            this.cmbEndTime.Size = new System.Drawing.Size(121, 21);
            this.cmbEndTime.TabIndex = 36;
            this.cmbEndTime.Validating += new System.ComponentModel.CancelEventHandler(this.cmbEndTime_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Clinic Start Date:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(37, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "Clinic End Date:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(37, 316);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "Shift Start Time:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(37, 339);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 13);
            this.label9.TabIndex = 40;
            this.label9.Text = "Shift End Time:";
            // 
            // chkOT
            // 
            this.chkOT.AutoSize = true;
            this.chkOT.Location = new System.Drawing.Point(168, 155);
            this.chkOT.Name = "chkOT";
            this.chkOT.Size = new System.Drawing.Size(131, 17);
            this.chkOT.TabIndex = 41;
            this.chkOT.Text = "Occupational Therapy";
            this.chkOT.UseVisualStyleBackColor = true;
            this.chkOT.Validating += new System.ComponentModel.CancelEventHandler(this.chkOT_Validating);
            // 
            // chkPT
            // 
            this.chkPT.AutoSize = true;
            this.chkPT.Location = new System.Drawing.Point(168, 179);
            this.chkPT.Name = "chkPT";
            this.chkPT.Size = new System.Drawing.Size(107, 17);
            this.chkPT.TabIndex = 42;
            this.chkPT.Text = "Physical Therapy";
            this.chkPT.UseVisualStyleBackColor = true;
            this.chkPT.Validating += new System.ComponentModel.CancelEventHandler(this.chkPT_Validating);
            // 
            // chkST
            // 
            this.chkST.AutoSize = true;
            this.chkST.Location = new System.Drawing.Point(168, 203);
            this.chkST.Name = "chkST";
            this.chkST.Size = new System.Drawing.Size(105, 17);
            this.chkST.TabIndex = 43;
            this.chkST.Text = "Speech Therapy";
            this.chkST.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(389, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 165);
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // frmAddTherapist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(633, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.chkST);
            this.Controls.Add(this.chkPT);
            this.Controls.Add(this.chkOT);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbEndTime);
            this.Controls.Add(this.cmbStartTime);
            this.Controls.Add(this.dtClinicEndDate);
            this.Controls.Add(this.dtClinicStartDate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtDOB);
            this.Controls.Add(this.txtContactNo);
            this.Controls.Add(this.txtTherapistName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddTherapist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add New Therapist";
            this.Load += new System.EventHandler(this.AddTherapist_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtDOB;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.TextBox txtTherapistName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoM;
        private System.Windows.Forms.RadioButton rdoF;
        private System.Windows.Forms.DateTimePicker dtClinicStartDate;
        private System.Windows.Forms.DateTimePicker dtClinicEndDate;
        private System.Windows.Forms.ComboBox cmbStartTime;
        private System.Windows.Forms.ComboBox cmbEndTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chkOT;
        private System.Windows.Forms.CheckBox chkPT;
        private System.Windows.Forms.CheckBox chkST;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}