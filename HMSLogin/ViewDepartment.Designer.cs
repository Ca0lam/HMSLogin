﻿namespace HMSLogin
{
    partial class ViewDepartment
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
            this.Cbx_Ward = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Cbx_Room = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Cbx_Bed = new System.Windows.Forms.ComboBox();
            this.Btn_View_Ward = new System.Windows.Forms.Button();
            this.Btn_ViewRoom = new System.Windows.Forms.Button();
            this.Btn_View_Bed = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Cbx_Department = new System.Windows.Forms.ComboBox();
            this.Lbl_NumBeds = new System.Windows.Forms.Label();
            this.Lbl_EmptyBeds = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Cbx_Ward
            // 
            this.Cbx_Ward.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbx_Ward.FormattingEnabled = true;
            this.Cbx_Ward.Location = new System.Drawing.Point(76, 37);
            this.Cbx_Ward.Name = "Cbx_Ward";
            this.Cbx_Ward.Size = new System.Drawing.Size(121, 21);
            this.Cbx_Ward.TabIndex = 0;
            this.Cbx_Ward.SelectedIndexChanged += new System.EventHandler(this.Cbx_Ward_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ward";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Room";
            // 
            // Cbx_Room
            // 
            this.Cbx_Room.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbx_Room.FormattingEnabled = true;
            this.Cbx_Room.Location = new System.Drawing.Point(76, 70);
            this.Cbx_Room.Name = "Cbx_Room";
            this.Cbx_Room.Size = new System.Drawing.Size(121, 21);
            this.Cbx_Room.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Bed";
            // 
            // Cbx_Bed
            // 
            this.Cbx_Bed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbx_Bed.FormattingEnabled = true;
            this.Cbx_Bed.Location = new System.Drawing.Point(76, 102);
            this.Cbx_Bed.Name = "Cbx_Bed";
            this.Cbx_Bed.Size = new System.Drawing.Size(121, 21);
            this.Cbx_Bed.TabIndex = 5;
            // 
            // Btn_View_Ward
            // 
            this.Btn_View_Ward.Location = new System.Drawing.Point(203, 37);
            this.Btn_View_Ward.Name = "Btn_View_Ward";
            this.Btn_View_Ward.Size = new System.Drawing.Size(109, 23);
            this.Btn_View_Ward.TabIndex = 6;
            this.Btn_View_Ward.Text = "View Ward";
            this.Btn_View_Ward.UseVisualStyleBackColor = true;
            this.Btn_View_Ward.Click += new System.EventHandler(this.Btn_View_Ward_Click);
            // 
            // Btn_ViewRoom
            // 
            this.Btn_ViewRoom.Location = new System.Drawing.Point(203, 68);
            this.Btn_ViewRoom.Name = "Btn_ViewRoom";
            this.Btn_ViewRoom.Size = new System.Drawing.Size(109, 23);
            this.Btn_ViewRoom.TabIndex = 7;
            this.Btn_ViewRoom.Text = "View Room";
            this.Btn_ViewRoom.UseVisualStyleBackColor = true;
            this.Btn_ViewRoom.Click += new System.EventHandler(this.Btn_ViewRoom_Click);
            // 
            // Btn_View_Bed
            // 
            this.Btn_View_Bed.Location = new System.Drawing.Point(203, 100);
            this.Btn_View_Bed.Name = "Btn_View_Bed";
            this.Btn_View_Bed.Size = new System.Drawing.Size(109, 23);
            this.Btn_View_Bed.TabIndex = 8;
            this.Btn_View_Bed.Text = "View Bed";
            this.Btn_View_Bed.UseVisualStyleBackColor = true;
            this.Btn_View_Bed.Click += new System.EventHandler(this.Btn_View_Bed_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Department";
            // 
            // Cbx_Department
            // 
            this.Cbx_Department.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbx_Department.FormattingEnabled = true;
            this.Cbx_Department.Location = new System.Drawing.Point(76, 8);
            this.Cbx_Department.Name = "Cbx_Department";
            this.Cbx_Department.Size = new System.Drawing.Size(121, 21);
            this.Cbx_Department.TabIndex = 9;
            this.Cbx_Department.SelectedIndexChanged += new System.EventHandler(this.Cbx_Department_SelectedIndexChanged);
            // 
            // Lbl_NumBeds
            // 
            this.Lbl_NumBeds.AutoSize = true;
            this.Lbl_NumBeds.Location = new System.Drawing.Point(11, 144);
            this.Lbl_NumBeds.Name = "Lbl_NumBeds";
            this.Lbl_NumBeds.Size = new System.Drawing.Size(151, 13);
            this.Lbl_NumBeds.TabIndex = 11;
            this.Lbl_NumBeds.Text = "Total Number of Beds In Dept:";
            // 
            // Lbl_EmptyBeds
            // 
            this.Lbl_EmptyBeds.AutoSize = true;
            this.Lbl_EmptyBeds.Location = new System.Drawing.Point(11, 169);
            this.Lbl_EmptyBeds.Name = "Lbl_EmptyBeds";
            this.Lbl_EmptyBeds.Size = new System.Drawing.Size(96, 13);
            this.Lbl_EmptyBeds.TabIndex = 12;
            this.Lbl_EmptyBeds.Text = "Total Empty Beds: ";
            // 
            // ViewDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 203);
            this.Controls.Add(this.Lbl_EmptyBeds);
            this.Controls.Add(this.Lbl_NumBeds);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Cbx_Department);
            this.Controls.Add(this.Btn_View_Bed);
            this.Controls.Add(this.Btn_ViewRoom);
            this.Controls.Add(this.Btn_View_Ward);
            this.Controls.Add(this.Cbx_Bed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Cbx_Room);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cbx_Ward);
            this.Name = "ViewDepartment";
            this.Text = "ViewDepartment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Cbx_Ward;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Cbx_Room;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Cbx_Bed;
        private System.Windows.Forms.Button Btn_View_Ward;
        private System.Windows.Forms.Button Btn_ViewRoom;
        private System.Windows.Forms.Button Btn_View_Bed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Cbx_Department;
        private System.Windows.Forms.Label Lbl_NumBeds;
        private System.Windows.Forms.Label Lbl_EmptyBeds;
    }
}