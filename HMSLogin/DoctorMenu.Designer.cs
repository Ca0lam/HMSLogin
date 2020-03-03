namespace HMSLogin
{
    partial class DoctorMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenerateReports = new System.Windows.Forms.Button();
            this.btnPatientDetails = new System.Windows.Forms.Button();
            this.btnTestResults = new System.Windows.Forms.Button();
            this.btnWritePrescription = new System.Windows.Forms.Button();
            this.btnHospitalLayout = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doctor Menu";
            // 
            // btnGenerateReports
            // 
            this.btnGenerateReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateReports.Location = new System.Drawing.Point(126, 100);
            this.btnGenerateReports.Name = "btnGenerateReports";
            this.btnGenerateReports.Size = new System.Drawing.Size(116, 40);
            this.btnGenerateReports.TabIndex = 1;
            this.btnGenerateReports.Text = "Generate Reports";
            this.btnGenerateReports.UseVisualStyleBackColor = true;
            this.btnGenerateReports.Click += new System.EventHandler(this.btnGenerateReports_Click);
            // 
            // btnPatientDetails
            // 
            this.btnPatientDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatientDetails.Location = new System.Drawing.Point(126, 146);
            this.btnPatientDetails.Name = "btnPatientDetails";
            this.btnPatientDetails.Size = new System.Drawing.Size(116, 40);
            this.btnPatientDetails.TabIndex = 2;
            this.btnPatientDetails.Text = "Patient Details";
            this.btnPatientDetails.UseVisualStyleBackColor = true;
            this.btnPatientDetails.Click += new System.EventHandler(this.btnPatientDetails_Click);
            // 
            // btnTestResults
            // 
            this.btnTestResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestResults.Location = new System.Drawing.Point(126, 192);
            this.btnTestResults.Name = "btnTestResults";
            this.btnTestResults.Size = new System.Drawing.Size(116, 40);
            this.btnTestResults.TabIndex = 3;
            this.btnTestResults.Text = "Test Results";
            this.btnTestResults.UseVisualStyleBackColor = true;
            this.btnTestResults.Click += new System.EventHandler(this.btnTestResults_Click);
            // 
            // btnWritePrescription
            // 
            this.btnWritePrescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWritePrescription.Location = new System.Drawing.Point(126, 238);
            this.btnWritePrescription.Name = "btnWritePrescription";
            this.btnWritePrescription.Size = new System.Drawing.Size(116, 40);
            this.btnWritePrescription.TabIndex = 4;
            this.btnWritePrescription.Text = "Write Prescription";
            this.btnWritePrescription.UseVisualStyleBackColor = true;
            this.btnWritePrescription.Click += new System.EventHandler(this.btnWritePrescription_Click);
            // 
            // btnHospitalLayout
            // 
            this.btnHospitalLayout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHospitalLayout.Location = new System.Drawing.Point(126, 284);
            this.btnHospitalLayout.Name = "btnHospitalLayout";
            this.btnHospitalLayout.Size = new System.Drawing.Size(116, 40);
            this.btnHospitalLayout.TabIndex = 5;
            this.btnHospitalLayout.Text = "Hospital Layout";
            this.btnHospitalLayout.UseVisualStyleBackColor = true;
            this.btnHospitalLayout.Click += new System.EventHandler(this.btnHospitalLayout_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(12, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 40);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // DoctorMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 360);
            this.ControlBox = false;
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnHospitalLayout);
            this.Controls.Add(this.btnWritePrescription);
            this.Controls.Add(this.btnTestResults);
            this.Controls.Add(this.btnPatientDetails);
            this.Controls.Add(this.btnGenerateReports);
            this.Controls.Add(this.label1);
            this.Name = "DoctorMenu";
            this.Text = "DoctorMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerateReports;
        private System.Windows.Forms.Button btnPatientDetails;
        private System.Windows.Forms.Button btnTestResults;
        private System.Windows.Forms.Button btnWritePrescription;
        private System.Windows.Forms.Button btnHospitalLayout;
        private System.Windows.Forms.Button btnLogout;
    }
}