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
            this.btnClose = new System.Windows.Forms.Button();
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
            this.GrbPersonalDetails.Location = new System.Drawing.Point(14, 58);
            this.GrbPersonalDetails.Margin = new System.Windows.Forms.Padding(2);
            this.GrbPersonalDetails.Name = "GrbPersonalDetails";
            this.GrbPersonalDetails.Padding = new System.Windows.Forms.Padding(2);
            this.GrbPersonalDetails.Size = new System.Drawing.Size(334, 372);
            this.GrbPersonalDetails.TabIndex = 0;
            this.GrbPersonalDetails.TabStop = false;
            this.GrbPersonalDetails.Text = "Personal Details";
            // 
            // MthDOB
            // 
            this.MthDOB.Location = new System.Drawing.Point(92, 194);
            this.MthDOB.Margin = new System.Windows.Forms.Padding(7);
            this.MthDOB.Name = "MthDOB";
            this.MthDOB.TabIndex = 9;
            // 
            // CmbGender
            // 
            this.CmbGender.FormattingEnabled = true;
            this.CmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.CmbGender.Location = new System.Drawing.Point(92, 107);
            this.CmbGender.Margin = new System.Windows.Forms.Padding(2);
            this.CmbGender.Name = "CmbGender";
            this.CmbGender.Size = new System.Drawing.Size(92, 23);
            this.CmbGender.TabIndex = 9;
            // 
            // TxtAddress
            // 
            this.TxtAddress.Location = new System.Drawing.Point(92, 151);
            this.TxtAddress.Margin = new System.Windows.Forms.Padding(2);
            this.TxtAddress.Multiline = true;
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(227, 39);
            this.TxtAddress.TabIndex = 10;
            // 
            // TxtSurname
            // 
            this.TxtSurname.Location = new System.Drawing.Point(92, 61);
            this.TxtSurname.Margin = new System.Windows.Forms.Padding(2);
            this.TxtSurname.Name = "TxtSurname";
            this.TxtSurname.Size = new System.Drawing.Size(134, 21);
            this.TxtSurname.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Firstname";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 203);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "DOB";
            // 
            // TxtFirstname
            // 
            this.TxtFirstname.Location = new System.Drawing.Point(92, 24);
            this.TxtFirstname.Margin = new System.Windows.Forms.Padding(2);
            this.TxtFirstname.Name = "TxtFirstname";
            this.TxtFirstname.Size = new System.Drawing.Size(134, 21);
            this.TxtFirstname.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 64);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Surname";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 154);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Gender";
            // 
            // GrbContactDetails
            // 
            this.GrbContactDetails.Controls.Add(this.TxtMobileNo);
            this.GrbContactDetails.Controls.Add(this.label7);
            this.GrbContactDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrbContactDetails.Location = new System.Drawing.Point(353, 58);
            this.GrbContactDetails.Margin = new System.Windows.Forms.Padding(2);
            this.GrbContactDetails.Name = "GrbContactDetails";
            this.GrbContactDetails.Padding = new System.Windows.Forms.Padding(2);
            this.GrbContactDetails.Size = new System.Drawing.Size(267, 70);
            this.GrbContactDetails.TabIndex = 1;
            this.GrbContactDetails.TabStop = false;
            this.GrbContactDetails.Text = "Contact Details";
            // 
            // TxtMobileNo
            // 
            this.TxtMobileNo.Location = new System.Drawing.Point(116, 26);
            this.TxtMobileNo.Margin = new System.Windows.Forms.Padding(2);
            this.TxtMobileNo.Name = "TxtMobileNo";
            this.TxtMobileNo.Size = new System.Drawing.Size(134, 21);
            this.TxtMobileNo.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 28);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Mobile No";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 31);
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
            this.GrbEmergencyContactDetails.Location = new System.Drawing.Point(353, 145);
            this.GrbEmergencyContactDetails.Margin = new System.Windows.Forms.Padding(2);
            this.GrbEmergencyContactDetails.Name = "GrbEmergencyContactDetails";
            this.GrbEmergencyContactDetails.Padding = new System.Windows.Forms.Padding(2);
            this.GrbEmergencyContactDetails.Size = new System.Drawing.Size(267, 173);
            this.GrbEmergencyContactDetails.TabIndex = 2;
            this.GrbEmergencyContactDetails.TabStop = false;
            this.GrbEmergencyContactDetails.Text = "Emergency Contact Details";
            // 
            // TxtRelationship
            // 
            this.TxtRelationship.Location = new System.Drawing.Point(116, 139);
            this.TxtRelationship.Margin = new System.Windows.Forms.Padding(2);
            this.TxtRelationship.Name = "TxtRelationship";
            this.TxtRelationship.Size = new System.Drawing.Size(134, 21);
            this.TxtRelationship.TabIndex = 14;
            // 
            // TxtPhoneNo
            // 
            this.TxtPhoneNo.Location = new System.Drawing.Point(116, 85);
            this.TxtPhoneNo.Margin = new System.Windows.Forms.Padding(2);
            this.TxtPhoneNo.Name = "TxtPhoneNo";
            this.TxtPhoneNo.Size = new System.Drawing.Size(134, 21);
            this.TxtPhoneNo.TabIndex = 13;
            // 
            // TxtPersonsName
            // 
            this.TxtPersonsName.Location = new System.Drawing.Point(116, 34);
            this.TxtPersonsName.Margin = new System.Windows.Forms.Padding(2);
            this.TxtPersonsName.Name = "TxtPersonsName";
            this.TxtPersonsName.Size = new System.Drawing.Size(134, 21);
            this.TxtPersonsName.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 144);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 15);
            this.label10.TabIndex = 5;
            this.label10.Text = "Relationship";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 37);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 15);
            this.label8.TabIndex = 3;
            this.label8.Text = "Persons Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 88);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 15);
            this.label9.TabIndex = 4;
            this.label9.Text = "Phone No";
            // 
            // BtnCreate
            // 
            this.BtnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCreate.Location = new System.Drawing.Point(424, 333);
            this.BtnCreate.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(133, 37);
            this.BtnCreate.TabIndex = 3;
            this.BtnCreate.Text = "Create";
            this.BtnCreate.UseVisualStyleBackColor = true;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(424, 385);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(133, 36);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 451);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.BtnCreate);
            this.Controls.Add(this.GrbEmergencyContactDetails);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GrbContactDetails);
            this.Controls.Add(this.GrbPersonalDetails);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Button btnClose;
    }
}