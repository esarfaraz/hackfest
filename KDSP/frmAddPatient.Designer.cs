
namespace KDSP
{
    partial class frmAddPatient
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
            this.btnRegister = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.txtFatherName = new System.Windows.Forms.TextBox();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.dtDOB = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoF = new System.Windows.Forms.RadioButton();
            this.rdoM = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoOT = new System.Windows.Forms.RadioButton();
            this.rdoPT = new System.Windows.Forms.RadioButton();
            this.rdoST = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(33, 309);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 0;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Patient Name:";
            // 
            // txtPatientName
            // 
            this.txtPatientName.Location = new System.Drawing.Point(153, 54);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(200, 20);
            this.txtPatientName.TabIndex = 2;
            // 
            // txtFatherName
            // 
            this.txtFatherName.Location = new System.Drawing.Point(153, 91);
            this.txtFatherName.Name = "txtFatherName";
            this.txtFatherName.Size = new System.Drawing.Size(200, 20);
            this.txtFatherName.TabIndex = 3;
            // 
            // txtContactNo
            // 
            this.txtContactNo.Location = new System.Drawing.Point(153, 118);
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(200, 20);
            this.txtContactNo.TabIndex = 4;
            // 
            // dtDOB
            // 
            this.dtDOB.Location = new System.Drawing.Point(153, 178);
            this.dtDOB.Name = "dtDOB";
            this.dtDOB.Size = new System.Drawing.Size(200, 20);
            this.dtDOB.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Father Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Contact No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Gender:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Date Of Birth:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Therapy Required:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(153, 308);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoM);
            this.groupBox1.Controls.Add(this.rdoF);
            this.groupBox1.Location = new System.Drawing.Point(153, 144);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 32);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoST);
            this.groupBox2.Controls.Add(this.rdoPT);
            this.groupBox2.Controls.Add(this.rdoOT);
            this.groupBox2.Location = new System.Drawing.Point(153, 202);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            // 
            // rdoOT
            // 
            this.rdoOT.AutoSize = true;
            this.rdoOT.Location = new System.Drawing.Point(7, 20);
            this.rdoOT.Name = "rdoOT";
            this.rdoOT.Size = new System.Drawing.Size(130, 17);
            this.rdoOT.TabIndex = 0;
            this.rdoOT.TabStop = true;
            this.rdoOT.Text = "Occupational Therapy";
            this.rdoOT.UseVisualStyleBackColor = true;
            // 
            // rdoPT
            // 
            this.rdoPT.AutoSize = true;
            this.rdoPT.Location = new System.Drawing.Point(7, 44);
            this.rdoPT.Name = "rdoPT";
            this.rdoPT.Size = new System.Drawing.Size(106, 17);
            this.rdoPT.TabIndex = 1;
            this.rdoPT.TabStop = true;
            this.rdoPT.Text = "Physical Therapy";
            this.rdoPT.UseVisualStyleBackColor = true;
            // 
            // rdoST
            // 
            this.rdoST.AutoSize = true;
            this.rdoST.Location = new System.Drawing.Point(7, 68);
            this.rdoST.Name = "rdoST";
            this.rdoST.Size = new System.Drawing.Size(104, 17);
            this.rdoST.TabIndex = 2;
            this.rdoST.TabStop = true;
            this.rdoST.Text = "Speech Therapy";
            this.rdoST.UseVisualStyleBackColor = true;
            // 
            // frmAddPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtDOB);
            this.Controls.Add(this.txtContactNo);
            this.Controls.Add(this.txtFatherName);
            this.Controls.Add(this.txtPatientName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAddPatient";
            this.Text = "Register New Patient";
            this.Load += new System.EventHandler(this.frmAddPatient_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.TextBox txtFatherName;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.DateTimePicker dtDOB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoF;
        private System.Windows.Forms.RadioButton rdoM;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdoST;
        private System.Windows.Forms.RadioButton rdoPT;
        private System.Windows.Forms.RadioButton rdoOT;
    }
}

