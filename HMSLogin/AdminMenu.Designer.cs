namespace HMSLogin
{
    partial class AdminMenu
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
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnHospitalLayout = new System.Windows.Forms.Button();
            this.btnGenerateBills = new System.Windows.Forms.Button();
            this.btnDoctorDetails = new System.Windows.Forms.Button();
            this.btnPatientDetails = new System.Windows.Forms.Button();
            this.btnGenerateReports = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(28, 17);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 40);
            this.btnLogout.TabIndex = 13;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnHospitalLayout
            // 
            this.btnHospitalLayout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHospitalLayout.Location = new System.Drawing.Point(142, 289);
            this.btnHospitalLayout.Name = "btnHospitalLayout";
            this.btnHospitalLayout.Size = new System.Drawing.Size(116, 40);
            this.btnHospitalLayout.TabIndex = 12;
            this.btnHospitalLayout.Text = "Hospital Layout";
            this.btnHospitalLayout.UseVisualStyleBackColor = true;
            this.btnHospitalLayout.Click += new System.EventHandler(this.btnHospitalLayout_Click);
            // 
            // btnGenerateBills
            // 
            this.btnGenerateBills.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateBills.Location = new System.Drawing.Point(142, 243);
            this.btnGenerateBills.Name = "btnGenerateBills";
            this.btnGenerateBills.Size = new System.Drawing.Size(116, 40);
            this.btnGenerateBills.TabIndex = 11;
            this.btnGenerateBills.Text = "Generate Bills";
            this.btnGenerateBills.UseVisualStyleBackColor = true;
            this.btnGenerateBills.Click += new System.EventHandler(this.btnGenerateBills_Click);
            // 
            // btnDoctorDetails
            // 
            this.btnDoctorDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoctorDetails.Location = new System.Drawing.Point(142, 197);
            this.btnDoctorDetails.Name = "btnDoctorDetails";
            this.btnDoctorDetails.Size = new System.Drawing.Size(116, 40);
            this.btnDoctorDetails.TabIndex = 10;
            this.btnDoctorDetails.Text = "Doctor Details";
            this.btnDoctorDetails.UseVisualStyleBackColor = true;
            this.btnDoctorDetails.Click += new System.EventHandler(this.btnDoctorDetails_Click);
            // 
            // btnPatientDetails
            // 
            this.btnPatientDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatientDetails.Location = new System.Drawing.Point(142, 151);
            this.btnPatientDetails.Name = "btnPatientDetails";
            this.btnPatientDetails.Size = new System.Drawing.Size(116, 40);
            this.btnPatientDetails.TabIndex = 9;
            this.btnPatientDetails.Text = "Patient Details";
            this.btnPatientDetails.UseVisualStyleBackColor = true;
            this.btnPatientDetails.Click += new System.EventHandler(this.btnPatientDetails_Click);
            // 
            // btnGenerateReports
            // 
            this.btnGenerateReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateReports.Location = new System.Drawing.Point(142, 105);
            this.btnGenerateReports.Name = "btnGenerateReports";
            this.btnGenerateReports.Size = new System.Drawing.Size(116, 40);
            this.btnGenerateReports.TabIndex = 8;
            this.btnGenerateReports.Text = "Generate Reports";
            this.btnGenerateReports.UseVisualStyleBackColor = true;
            this.btnGenerateReports.Click += new System.EventHandler(this.btnGenerateReports_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Admin Menu";
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 361);
            this.ControlBox = false;
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnHospitalLayout);
            this.Controls.Add(this.btnGenerateBills);
            this.Controls.Add(this.btnDoctorDetails);
            this.Controls.Add(this.btnPatientDetails);
            this.Controls.Add(this.btnGenerateReports);
            this.Controls.Add(this.label1);
            this.Name = "AdminMenu";
            this.Text = "AdminMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnHospitalLayout;
        private System.Windows.Forms.Button btnGenerateBills;
        private System.Windows.Forms.Button btnDoctorDetails;
        private System.Windows.Forms.Button btnPatientDetails;
        private System.Windows.Forms.Button btnGenerateReports;
        private System.Windows.Forms.Label label1;
    }
}