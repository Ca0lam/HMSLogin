namespace HMSLogin
{
    partial class ViewBeds
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
            this.Btn_ViewDepartment = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Cbx_Department = new System.Windows.Forms.ComboBox();
            this.Btn_ViewRoom = new System.Windows.Forms.Button();
            this.Btn_View_Ward = new System.Windows.Forms.Button();
            this.Cbx_Bed = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Cbx_Room = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Cbx_Ward = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Btn_ViewDepartment
            // 
            this.Btn_ViewDepartment.Location = new System.Drawing.Point(206, 87);
            this.Btn_ViewDepartment.Name = "Btn_ViewDepartment";
            this.Btn_ViewDepartment.Size = new System.Drawing.Size(109, 23);
            this.Btn_ViewDepartment.TabIndex = 47;
            this.Btn_ViewDepartment.Text = "View Department";
            this.Btn_ViewDepartment.UseVisualStyleBackColor = true;
            this.Btn_ViewDepartment.Click += new System.EventHandler(this.Btn_ViewDepartment_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Department";
            // 
            // Cbx_Department
            // 
            this.Cbx_Department.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbx_Department.FormattingEnabled = true;
            this.Cbx_Department.Location = new System.Drawing.Point(79, 89);
            this.Cbx_Department.Name = "Cbx_Department";
            this.Cbx_Department.Size = new System.Drawing.Size(121, 21);
            this.Cbx_Department.TabIndex = 45;
            // 
            // Btn_ViewRoom
            // 
            this.Btn_ViewRoom.Location = new System.Drawing.Point(206, 31);
            this.Btn_ViewRoom.Name = "Btn_ViewRoom";
            this.Btn_ViewRoom.Size = new System.Drawing.Size(109, 23);
            this.Btn_ViewRoom.TabIndex = 43;
            this.Btn_ViewRoom.Text = "View Room";
            this.Btn_ViewRoom.UseVisualStyleBackColor = true;
            this.Btn_ViewRoom.Click += new System.EventHandler(this.Btn_ViewRoom_Click);
            // 
            // Btn_View_Ward
            // 
            this.Btn_View_Ward.Location = new System.Drawing.Point(206, 60);
            this.Btn_View_Ward.Name = "Btn_View_Ward";
            this.Btn_View_Ward.Size = new System.Drawing.Size(109, 23);
            this.Btn_View_Ward.TabIndex = 42;
            this.Btn_View_Ward.Text = "View Ward";
            this.Btn_View_Ward.UseVisualStyleBackColor = true;
            this.Btn_View_Ward.Click += new System.EventHandler(this.Btn_View_Ward_Click);
            // 
            // Cbx_Bed
            // 
            this.Cbx_Bed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbx_Bed.FormattingEnabled = true;
            this.Cbx_Bed.Location = new System.Drawing.Point(79, 6);
            this.Cbx_Bed.Name = "Cbx_Bed";
            this.Cbx_Bed.Size = new System.Drawing.Size(121, 21);
            this.Cbx_Bed.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Bed";
            // 
            // Cbx_Room
            // 
            this.Cbx_Room.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbx_Room.FormattingEnabled = true;
            this.Cbx_Room.Location = new System.Drawing.Point(79, 33);
            this.Cbx_Room.Name = "Cbx_Room";
            this.Cbx_Room.Size = new System.Drawing.Size(121, 21);
            this.Cbx_Room.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Room";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Ward";
            // 
            // Cbx_Ward
            // 
            this.Cbx_Ward.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbx_Ward.FormattingEnabled = true;
            this.Cbx_Ward.Location = new System.Drawing.Point(79, 62);
            this.Cbx_Ward.Name = "Cbx_Ward";
            this.Cbx_Ward.Size = new System.Drawing.Size(121, 21);
            this.Cbx_Ward.TabIndex = 36;
            // 
            // ViewBeds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 127);
            this.Controls.Add(this.Btn_ViewDepartment);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Cbx_Department);
            this.Controls.Add(this.Btn_ViewRoom);
            this.Controls.Add(this.Btn_View_Ward);
            this.Controls.Add(this.Cbx_Bed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Cbx_Room);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cbx_Ward);
            this.Name = "ViewBeds";
            this.Text = "ViewBeds";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_ViewDepartment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Cbx_Department;
        private System.Windows.Forms.Button Btn_ViewRoom;
        private System.Windows.Forms.Button Btn_View_Ward;
        private System.Windows.Forms.ComboBox Cbx_Bed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Cbx_Room;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Cbx_Ward;
    }
}