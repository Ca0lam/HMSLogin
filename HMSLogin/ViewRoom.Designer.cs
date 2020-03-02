namespace HMSLogin
{
    partial class ViewRoom
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
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Cbx_Department = new System.Windows.Forms.ComboBox();
            this.Btn_View_Bed = new System.Windows.Forms.Button();
            this.Btn_View_Ward = new System.Windows.Forms.Button();
            this.Cbx_Bed = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Cbx_Room = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Cbx_Ward = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(195, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 23);
            this.button1.TabIndex = 35;
            this.button1.Text = "View Department";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Department";
            // 
            // Cbx_Department
            // 
            this.Cbx_Department.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbx_Department.FormattingEnabled = true;
            this.Cbx_Department.Location = new System.Drawing.Point(68, 68);
            this.Cbx_Department.Name = "Cbx_Department";
            this.Cbx_Department.Size = new System.Drawing.Size(121, 21);
            this.Cbx_Department.TabIndex = 33;
            // 
            // Btn_View_Bed
            // 
            this.Btn_View_Bed.Location = new System.Drawing.Point(195, 98);
            this.Btn_View_Bed.Name = "Btn_View_Bed";
            this.Btn_View_Bed.Size = new System.Drawing.Size(109, 23);
            this.Btn_View_Bed.TabIndex = 32;
            this.Btn_View_Bed.Text = "View Bed";
            this.Btn_View_Bed.UseVisualStyleBackColor = true;
            // 
            // Btn_View_Ward
            // 
            this.Btn_View_Ward.Location = new System.Drawing.Point(195, 39);
            this.Btn_View_Ward.Name = "Btn_View_Ward";
            this.Btn_View_Ward.Size = new System.Drawing.Size(109, 23);
            this.Btn_View_Ward.TabIndex = 30;
            this.Btn_View_Ward.Text = "View Ward";
            this.Btn_View_Ward.UseVisualStyleBackColor = true;
            // 
            // Cbx_Bed
            // 
            this.Cbx_Bed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbx_Bed.FormattingEnabled = true;
            this.Cbx_Bed.Location = new System.Drawing.Point(68, 100);
            this.Cbx_Bed.Name = "Cbx_Bed";
            this.Cbx_Bed.Size = new System.Drawing.Size(121, 21);
            this.Cbx_Bed.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Bed";
            // 
            // Cbx_Room
            // 
            this.Cbx_Room.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbx_Room.FormattingEnabled = true;
            this.Cbx_Room.Location = new System.Drawing.Point(68, 12);
            this.Cbx_Room.Name = "Cbx_Room";
            this.Cbx_Room.Size = new System.Drawing.Size(121, 21);
            this.Cbx_Room.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Room";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Ward";
            // 
            // Cbx_Ward
            // 
            this.Cbx_Ward.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbx_Ward.FormattingEnabled = true;
            this.Cbx_Ward.Location = new System.Drawing.Point(68, 41);
            this.Cbx_Ward.Name = "Cbx_Ward";
            this.Cbx_Ward.Size = new System.Drawing.Size(121, 21);
            this.Cbx_Ward.TabIndex = 24;
            // 
            // ViewRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 148);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Cbx_Department);
            this.Controls.Add(this.Btn_View_Bed);
            this.Controls.Add(this.Btn_View_Ward);
            this.Controls.Add(this.Cbx_Bed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Cbx_Room);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cbx_Ward);
            this.Name = "ViewRoom";
            this.Text = "ViewRoom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Cbx_Department;
        private System.Windows.Forms.Button Btn_View_Bed;
        private System.Windows.Forms.Button Btn_View_Ward;
        private System.Windows.Forms.ComboBox Cbx_Bed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Cbx_Room;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Cbx_Ward;
    }
}