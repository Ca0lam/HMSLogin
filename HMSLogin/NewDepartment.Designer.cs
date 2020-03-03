namespace HMSLogin
{
    partial class NewDepartment
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Cbx_DepartmentId = new System.Windows.Forms.ComboBox();
            this.Txt_DepartmentName = new System.Windows.Forms.TextBox();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Department ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Department Name:";
            // 
            // Cbx_DepartmentId
            // 
            this.Cbx_DepartmentId.FormattingEnabled = true;
            this.Cbx_DepartmentId.Location = new System.Drawing.Point(115, 9);
            this.Cbx_DepartmentId.Name = "Cbx_DepartmentId";
            this.Cbx_DepartmentId.Size = new System.Drawing.Size(216, 21);
            this.Cbx_DepartmentId.TabIndex = 3;
            // 
            // Txt_DepartmentName
            // 
            this.Txt_DepartmentName.Location = new System.Drawing.Point(115, 40);
            this.Txt_DepartmentName.Name = "Txt_DepartmentName";
            this.Txt_DepartmentName.Size = new System.Drawing.Size(216, 20);
            this.Txt_DepartmentName.TabIndex = 4;
            // 
            // Btn_Save
            // 
            this.Btn_Save.Location = new System.Drawing.Point(255, 67);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(75, 23);
            this.Btn_Save.TabIndex = 5;
            this.Btn_Save.Text = "Save";
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // ViewDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 101);
            this.Controls.Add(this.Btn_Save);
            this.Controls.Add(this.Txt_DepartmentName);
            this.Controls.Add(this.Cbx_DepartmentId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "ViewDepartment";
            this.Text = "ViewDepartment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Cbx_DepartmentId;
        private System.Windows.Forms.TextBox Txt_DepartmentName;
        private System.Windows.Forms.Button Btn_Save;
    }
}