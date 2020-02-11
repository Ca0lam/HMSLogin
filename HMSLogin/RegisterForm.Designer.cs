namespace HMSLogin
{
    partial class RegisterForm
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
            this.GrbPersonalDetails = new System.Windows.Forms.GroupBox();
            this.MthDOB = new System.Windows.Forms.MonthCalendar();
            this.CmbGender = new System.Windows.Forms.ComboBox();
            this.TxtAddress = new System.Windows.Forms.TextBox();
            this.TxtSurname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtFirstname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GrbContactDetails = new System.Windows.Forms.GroupBox();
            this.TxtMobileNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GrbEmergencyContactDetails = new System.Windows.Forms.GroupBox();
            this.TxtRelationship = new System.Windows.Forms.TextBox();
            this.TxtPhoneNo = new System.Windows.Forms.TextBox();
            this.TxtPersonsName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.GrbPersonalDetails.SuspendLayout();
            this.GrbContactDetails.SuspendLayout();
            this.GrbEmergencyContactDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrbPersonalDetails
            // 
            this.GrbPersonalDetails.Controls.Add(this.MthDOB);
            this.GrbPersonalDetails.Controls.Add(this.CmbGender);
            this.GrbPersonalDetails.Controls.Add(this.TxtAddress);
            this.GrbPersonalDetails.Controls.Add(this.TxtSurname);
            this.GrbPersonalDetails.Controls.Add(this.label2);
            this.GrbPersonalDetails.Controls.Add(this.label6);
            this.GrbPersonalDetails.Controls.Add(this.TxtFirstname);
            this.GrbPersonalDetails.Controls.Add(this.label4);
            this.GrbPersonalDetails.Controls.Add(this.label5);
            this.GrbPersonalDetails.Controls.Add(this.label3);
            this.GrbPersonalDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrbPersonalDetails.Location = new System.Drawing.Point(19, 71);
            this.GrbPersonalDetails.Name = "GrbPersonalDetails";
            this.GrbPersonalDetails.Size = new System.Drawing.Size(446, 458);
            this.GrbPersonalDetails.TabIndex = 0;
            this.GrbPersonalDetails.TabStop = false;
            this.GrbPersonalDetails.Text = "Personal Details";
            // 
            // MthDOB
            // 
            this.MthDOB.Location = new System.Drawing.Point(122, 239);
            this.MthDOB.Name = "MthDOB";
            this.MthDOB.TabIndex = 9;
            // 
            // CmbGender
            // 
            this.CmbGender.FormattingEnabled = true;
            this.CmbGender.Location = new System.Drawing.Point(122, 132);
            this.CmbGender.Name = "CmbGender";
            this.CmbGender.Size = new System.Drawing.Size(121, 26);
            this.CmbGender.TabIndex = 9;
            // 
            // TxtAddress
            // 
            this.TxtAddress.Location = new System.Drawing.Point(122, 186);
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(178, 24);
            this.TxtAddress.TabIndex = 10;
            // 
            // TxtSurname
            // 
            this.TxtSurname.Location = new System.Drawing.Point(122, 75);
            this.TxtSurname.Name = "TxtSurname";
            this.TxtSurname.Size = new System.Drawing.Size(178, 24);
            this.TxtSurname.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Firstname";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "DOB";
            // 
            // TxtFirstname
            // 
            this.TxtFirstname.Location = new System.Drawing.Point(122, 30);
            this.TxtFirstname.Name = "TxtFirstname";
            this.TxtFirstname.Size = new System.Drawing.Size(178, 24);
            this.TxtFirstname.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Surname";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Gender";
            // 
            // GrbContactDetails
            // 
            this.GrbContactDetails.Controls.Add(this.TxtMobileNo);
            this.GrbContactDetails.Controls.Add(this.label7);
            this.GrbContactDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrbContactDetails.Location = new System.Drawing.Point(471, 71);
            this.GrbContactDetails.Name = "GrbContactDetails";
            this.GrbContactDetails.Size = new System.Drawing.Size(356, 86);
            this.GrbContactDetails.TabIndex = 1;
            this.GrbContactDetails.TabStop = false;
            this.GrbContactDetails.Text = "Contact Details";
            // 
            // TxtMobileNo
            // 
            this.TxtMobileNo.Location = new System.Drawing.Point(154, 32);
            this.TxtMobileNo.Name = "TxtMobileNo";
            this.TxtMobileNo.Size = new System.Drawing.Size(178, 24);
            this.TxtMobileNo.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 18);
            this.label7.TabIndex = 8;
            this.label7.Text = "Mobile No";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Register";
            // 
            // GrbEmergencyContactDetails
            // 
            this.GrbEmergencyContactDetails.Controls.Add(this.TxtRelationship);
            this.GrbEmergencyContactDetails.Controls.Add(this.TxtPhoneNo);
            this.GrbEmergencyContactDetails.Controls.Add(this.TxtPersonsName);
            this.GrbEmergencyContactDetails.Controls.Add(this.label10);
            this.GrbEmergencyContactDetails.Controls.Add(this.label8);
            this.GrbEmergencyContactDetails.Controls.Add(this.label9);
            this.GrbEmergencyContactDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrbEmergencyContactDetails.Location = new System.Drawing.Point(471, 179);
            this.GrbEmergencyContactDetails.Name = "GrbEmergencyContactDetails";
            this.GrbEmergencyContactDetails.Size = new System.Drawing.Size(356, 213);
            this.GrbEmergencyContactDetails.TabIndex = 2;
            this.GrbEmergencyContactDetails.TabStop = false;
            this.GrbEmergencyContactDetails.Text = "Emergency Contact Details";
            // 
            // TxtRelationship
            // 
            this.TxtRelationship.Location = new System.Drawing.Point(154, 171);
            this.TxtRelationship.Name = "TxtRelationship";
            this.TxtRelationship.Size = new System.Drawing.Size(178, 24);
            this.TxtRelationship.TabIndex = 14;
            // 
            // TxtPhoneNo
            // 
            this.TxtPhoneNo.Location = new System.Drawing.Point(154, 105);
            this.TxtPhoneNo.Name = "TxtPhoneNo";
            this.TxtPhoneNo.Size = new System.Drawing.Size(178, 24);
            this.TxtPhoneNo.TabIndex = 13;
            // 
            // TxtPersonsName
            // 
            this.TxtPersonsName.Location = new System.Drawing.Point(154, 42);
            this.TxtPersonsName.Name = "TxtPersonsName";
            this.TxtPersonsName.Size = new System.Drawing.Size(178, 24);
            this.TxtPersonsName.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 177);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 18);
            this.label10.TabIndex = 5;
            this.label10.Text = "Relationship";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 18);
            this.label8.TabIndex = 3;
            this.label8.Text = "Persons Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 18);
            this.label9.TabIndex = 4;
            this.label9.Text = "Phone No";
            // 
            // BtnCreate
            // 
            this.BtnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCreate.Location = new System.Drawing.Point(541, 435);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(177, 46);
            this.BtnCreate.TabIndex = 3;
            this.BtnCreate.Text = "Create";
            this.BtnCreate.UseVisualStyleBackColor = true;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 595);
            this.ControlBox = false;
            this.Controls.Add(this.BtnCreate);
            this.Controls.Add(this.GrbEmergencyContactDetails);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GrbContactDetails);
            this.Controls.Add(this.GrbPersonalDetails);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.GrbPersonalDetails.ResumeLayout(false);
            this.GrbPersonalDetails.PerformLayout();
            this.GrbContactDetails.ResumeLayout(false);
            this.GrbContactDetails.PerformLayout();
            this.GrbEmergencyContactDetails.ResumeLayout(false);
            this.GrbEmergencyContactDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GrbPersonalDetails;
        private System.Windows.Forms.GroupBox GrbContactDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GrbEmergencyContactDetails;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MonthCalendar MthDOB;
        private System.Windows.Forms.ComboBox CmbGender;
        private System.Windows.Forms.TextBox TxtAddress;
        private System.Windows.Forms.TextBox TxtSurname;
        private System.Windows.Forms.TextBox TxtFirstname;
        private System.Windows.Forms.TextBox TxtMobileNo;
        private System.Windows.Forms.TextBox TxtRelationship;
        private System.Windows.Forms.TextBox TxtPhoneNo;
        private System.Windows.Forms.TextBox TxtPersonsName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BtnCreate;
    }
}