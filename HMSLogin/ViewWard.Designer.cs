namespace HMSLogin
{
    partial class ViewWard
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
            this.Btn_Save = new System.Windows.Forms.Button();
            this.Txt_WardName = new System.Windows.Forms.TextBox();
            this.Cbx_WardID = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Cbx_DepartmentId = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_Save
            // 
            this.Btn_Save.Location = new System.Drawing.Point(256, 109);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(75, 23);
            this.Btn_Save.TabIndex = 10;
            this.Btn_Save.Text = "Save";
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Txt_WardName
            // 
            this.Txt_WardName.Location = new System.Drawing.Point(115, 63);
            this.Txt_WardName.Name = "Txt_WardName";
            this.Txt_WardName.Size = new System.Drawing.Size(216, 20);
            this.Txt_WardName.TabIndex = 9;
            // 
            // Cbx_WardID
            // 
            this.Cbx_WardID.FormattingEnabled = true;
            this.Cbx_WardID.Location = new System.Drawing.Point(115, 9);
            this.Cbx_WardID.Name = "Cbx_WardID";
            this.Cbx_WardID.Size = new System.Drawing.Size(216, 21);
            this.Cbx_WardID.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Department ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ward ID:";
            // 
            // Cbx_DepartmentId
            // 
            this.Cbx_DepartmentId.FormattingEnabled = true;
            this.Cbx_DepartmentId.Location = new System.Drawing.Point(115, 36);
            this.Cbx_DepartmentId.Name = "Cbx_DepartmentId";
            this.Cbx_DepartmentId.Size = new System.Drawing.Size(216, 21);
            this.Cbx_DepartmentId.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ward Name:";
            // 
            // ViewWard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 168);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cbx_DepartmentId);
            this.Controls.Add(this.Btn_Save);
            this.Controls.Add(this.Txt_WardName);
            this.Controls.Add(this.Cbx_WardID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "ViewWard";
            this.Text = "ViewWard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.TextBox Txt_WardName;
        private System.Windows.Forms.ComboBox Cbx_WardID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Cbx_DepartmentId;
        private System.Windows.Forms.Label label1;
    }
}