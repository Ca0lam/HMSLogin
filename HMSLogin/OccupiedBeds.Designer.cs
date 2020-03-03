namespace HMSLogin
{
    partial class OccupiedBeds
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
            this.Lbl_TotalPublic = new System.Windows.Forms.Label();
            this.Lbl_TotalSemiPrivate = new System.Windows.Forms.Label();
            this.Lbl_TotalPrivate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Cbx_Public = new System.Windows.Forms.ComboBox();
            this.Cbx_Semiprivate = new System.Windows.Forms.ComboBox();
            this.Cbx_Private = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Cbx_Department = new System.Windows.Forms.ComboBox();
            this.Cbx_PrivatePatient = new System.Windows.Forms.ComboBox();
            this.Cbx_SemiPrivatePatient = new System.Windows.Forms.ComboBox();
            this.Cbx_PublicPatient = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lbl_TotalPublic
            // 
            this.Lbl_TotalPublic.AutoSize = true;
            this.Lbl_TotalPublic.Location = new System.Drawing.Point(270, 102);
            this.Lbl_TotalPublic.Name = "Lbl_TotalPublic";
            this.Lbl_TotalPublic.Size = new System.Drawing.Size(34, 13);
            this.Lbl_TotalPublic.TabIndex = 32;
            this.Lbl_TotalPublic.Text = "Total:";
            // 
            // Lbl_TotalSemiPrivate
            // 
            this.Lbl_TotalSemiPrivate.AutoSize = true;
            this.Lbl_TotalSemiPrivate.Location = new System.Drawing.Point(270, 71);
            this.Lbl_TotalSemiPrivate.Name = "Lbl_TotalSemiPrivate";
            this.Lbl_TotalSemiPrivate.Size = new System.Drawing.Size(34, 13);
            this.Lbl_TotalSemiPrivate.TabIndex = 31;
            this.Lbl_TotalSemiPrivate.Text = "Total:";
            // 
            // Lbl_TotalPrivate
            // 
            this.Lbl_TotalPrivate.AutoSize = true;
            this.Lbl_TotalPrivate.Location = new System.Drawing.Point(269, 46);
            this.Lbl_TotalPrivate.Name = "Lbl_TotalPrivate";
            this.Lbl_TotalPrivate.Size = new System.Drawing.Size(34, 13);
            this.Lbl_TotalPrivate.TabIndex = 30;
            this.Lbl_TotalPrivate.Text = "Total:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Public Rooms:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Semi-Private Rooms:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Private Rooms:";
            // 
            // Cbx_Public
            // 
            this.Cbx_Public.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbx_Public.FormattingEnabled = true;
            this.Cbx_Public.Location = new System.Drawing.Point(142, 99);
            this.Cbx_Public.Name = "Cbx_Public";
            this.Cbx_Public.Size = new System.Drawing.Size(121, 21);
            this.Cbx_Public.TabIndex = 26;
            this.Cbx_Public.SelectedIndexChanged += new System.EventHandler(this.Cbx_Public_SelectedIndexChanged);
            // 
            // Cbx_Semiprivate
            // 
            this.Cbx_Semiprivate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbx_Semiprivate.FormattingEnabled = true;
            this.Cbx_Semiprivate.Location = new System.Drawing.Point(142, 71);
            this.Cbx_Semiprivate.Name = "Cbx_Semiprivate";
            this.Cbx_Semiprivate.Size = new System.Drawing.Size(121, 21);
            this.Cbx_Semiprivate.TabIndex = 25;
            this.Cbx_Semiprivate.SelectedIndexChanged += new System.EventHandler(this.Cbx_Semiprivate_SelectedIndexChanged);
            // 
            // Cbx_Private
            // 
            this.Cbx_Private.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbx_Private.FormattingEnabled = true;
            this.Cbx_Private.Location = new System.Drawing.Point(142, 43);
            this.Cbx_Private.Name = "Cbx_Private";
            this.Cbx_Private.Size = new System.Drawing.Size(121, 21);
            this.Cbx_Private.TabIndex = 24;
            this.Cbx_Private.SelectedIndexChanged += new System.EventHandler(this.Cbx_Private_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Department:";
            // 
            // Cbx_Department
            // 
            this.Cbx_Department.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbx_Department.FormattingEnabled = true;
            this.Cbx_Department.Location = new System.Drawing.Point(142, 15);
            this.Cbx_Department.Name = "Cbx_Department";
            this.Cbx_Department.Size = new System.Drawing.Size(121, 21);
            this.Cbx_Department.TabIndex = 22;
            this.Cbx_Department.SelectedIndexChanged += new System.EventHandler(this.Cbx_Department_SelectedIndexChanged);
            // 
            // Cbx_PrivatePatient
            // 
            this.Cbx_PrivatePatient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbx_PrivatePatient.FormattingEnabled = true;
            this.Cbx_PrivatePatient.Location = new System.Drawing.Point(394, 43);
            this.Cbx_PrivatePatient.Name = "Cbx_PrivatePatient";
            this.Cbx_PrivatePatient.Size = new System.Drawing.Size(121, 21);
            this.Cbx_PrivatePatient.TabIndex = 33;
            // 
            // Cbx_SemiPrivatePatient
            // 
            this.Cbx_SemiPrivatePatient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbx_SemiPrivatePatient.FormattingEnabled = true;
            this.Cbx_SemiPrivatePatient.Location = new System.Drawing.Point(394, 71);
            this.Cbx_SemiPrivatePatient.Name = "Cbx_SemiPrivatePatient";
            this.Cbx_SemiPrivatePatient.Size = new System.Drawing.Size(121, 21);
            this.Cbx_SemiPrivatePatient.TabIndex = 34;
            // 
            // Cbx_PublicPatient
            // 
            this.Cbx_PublicPatient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbx_PublicPatient.FormattingEnabled = true;
            this.Cbx_PublicPatient.Location = new System.Drawing.Point(394, 99);
            this.Cbx_PublicPatient.Name = "Cbx_PublicPatient";
            this.Cbx_PublicPatient.Size = new System.Drawing.Size(121, 21);
            this.Cbx_PublicPatient.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(344, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Patient:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(344, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Patient:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(344, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "Patient:";
            // 
            // OccupiedBeds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 165);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Cbx_PublicPatient);
            this.Controls.Add(this.Cbx_SemiPrivatePatient);
            this.Controls.Add(this.Cbx_PrivatePatient);
            this.Controls.Add(this.Lbl_TotalPublic);
            this.Controls.Add(this.Lbl_TotalSemiPrivate);
            this.Controls.Add(this.Lbl_TotalPrivate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cbx_Public);
            this.Controls.Add(this.Cbx_Semiprivate);
            this.Controls.Add(this.Cbx_Private);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Cbx_Department);
            this.Name = "OccupiedBeds";
            this.Text = "OccupiedBeds";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_TotalPublic;
        private System.Windows.Forms.Label Lbl_TotalSemiPrivate;
        private System.Windows.Forms.Label Lbl_TotalPrivate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Cbx_Public;
        private System.Windows.Forms.ComboBox Cbx_Semiprivate;
        private System.Windows.Forms.ComboBox Cbx_Private;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Cbx_Department;
        private System.Windows.Forms.ComboBox Cbx_PrivatePatient;
        private System.Windows.Forms.ComboBox Cbx_SemiPrivatePatient;
        private System.Windows.Forms.ComboBox Cbx_PublicPatient;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}