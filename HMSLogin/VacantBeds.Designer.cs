namespace HMSLogin
{
    partial class VacantBeds
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
            this.label4 = new System.Windows.Forms.Label();
            this.Cbx_Department = new System.Windows.Forms.ComboBox();
            this.Cbx_Private = new System.Windows.Forms.ComboBox();
            this.Cbx_Semiprivate = new System.Windows.Forms.ComboBox();
            this.Cbx_Public = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Lbl_TotalPrivate = new System.Windows.Forms.Label();
            this.Lbl_TotalSemiPrivate = new System.Windows.Forms.Label();
            this.Lbl_TotalPublic = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Department:";
            // 
            // Cbx_Department
            // 
            this.Cbx_Department.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbx_Department.FormattingEnabled = true;
            this.Cbx_Department.Location = new System.Drawing.Point(130, 6);
            this.Cbx_Department.Name = "Cbx_Department";
            this.Cbx_Department.Size = new System.Drawing.Size(121, 21);
            this.Cbx_Department.TabIndex = 11;
            this.Cbx_Department.SelectedIndexChanged += new System.EventHandler(this.Cbx_Department_SelectedIndexChanged);
            // 
            // Cbx_Private
            // 
            this.Cbx_Private.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbx_Private.FormattingEnabled = true;
            this.Cbx_Private.Location = new System.Drawing.Point(130, 34);
            this.Cbx_Private.Name = "Cbx_Private";
            this.Cbx_Private.Size = new System.Drawing.Size(121, 21);
            this.Cbx_Private.TabIndex = 13;
            // 
            // Cbx_Semiprivate
            // 
            this.Cbx_Semiprivate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbx_Semiprivate.FormattingEnabled = true;
            this.Cbx_Semiprivate.Location = new System.Drawing.Point(130, 62);
            this.Cbx_Semiprivate.Name = "Cbx_Semiprivate";
            this.Cbx_Semiprivate.Size = new System.Drawing.Size(121, 21);
            this.Cbx_Semiprivate.TabIndex = 14;
            // 
            // Cbx_Public
            // 
            this.Cbx_Public.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbx_Public.FormattingEnabled = true;
            this.Cbx_Public.Location = new System.Drawing.Point(130, 90);
            this.Cbx_Public.Name = "Cbx_Public";
            this.Cbx_Public.Size = new System.Drawing.Size(121, 21);
            this.Cbx_Public.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Private Rooms:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Semi-Private Rooms:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Public Rooms:";
            // 
            // Lbl_TotalPrivate
            // 
            this.Lbl_TotalPrivate.AutoSize = true;
            this.Lbl_TotalPrivate.Location = new System.Drawing.Point(257, 37);
            this.Lbl_TotalPrivate.Name = "Lbl_TotalPrivate";
            this.Lbl_TotalPrivate.Size = new System.Drawing.Size(34, 13);
            this.Lbl_TotalPrivate.TabIndex = 19;
            this.Lbl_TotalPrivate.Text = "Total:";
            // 
            // Lbl_TotalSemiPrivate
            // 
            this.Lbl_TotalSemiPrivate.AutoSize = true;
            this.Lbl_TotalSemiPrivate.Location = new System.Drawing.Point(258, 62);
            this.Lbl_TotalSemiPrivate.Name = "Lbl_TotalSemiPrivate";
            this.Lbl_TotalSemiPrivate.Size = new System.Drawing.Size(34, 13);
            this.Lbl_TotalSemiPrivate.TabIndex = 20;
            this.Lbl_TotalSemiPrivate.Text = "Total:";
            // 
            // Lbl_TotalPublic
            // 
            this.Lbl_TotalPublic.AutoSize = true;
            this.Lbl_TotalPublic.Location = new System.Drawing.Point(258, 93);
            this.Lbl_TotalPublic.Name = "Lbl_TotalPublic";
            this.Lbl_TotalPublic.Size = new System.Drawing.Size(34, 13);
            this.Lbl_TotalPublic.TabIndex = 21;
            this.Lbl_TotalPublic.Text = "Total:";
            // 
            // VacantBeds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 180);
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
            this.Name = "VacantBeds";
            this.Text = "VacantBeds";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Cbx_Department;
        private System.Windows.Forms.ComboBox Cbx_Private;
        private System.Windows.Forms.ComboBox Cbx_Semiprivate;
        private System.Windows.Forms.ComboBox Cbx_Public;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Lbl_TotalPrivate;
        private System.Windows.Forms.Label Lbl_TotalSemiPrivate;
        private System.Windows.Forms.Label Lbl_TotalPublic;
    }
}