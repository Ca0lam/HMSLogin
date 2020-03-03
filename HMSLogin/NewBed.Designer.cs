namespace HMSLogin
{
    partial class NewBed
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
            this.Cbx_BedId = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Cbx_RoomId = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Btn_Save
            // 
            this.Btn_Save.Location = new System.Drawing.Point(255, 67);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(75, 23);
            this.Btn_Save.TabIndex = 10;
            this.Btn_Save.Text = "Save";
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Cbx_BedId
            // 
            this.Cbx_BedId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbx_BedId.Enabled = false;
            this.Cbx_BedId.FormattingEnabled = true;
            this.Cbx_BedId.Location = new System.Drawing.Point(115, 9);
            this.Cbx_BedId.Name = "Cbx_BedId";
            this.Cbx_BedId.Size = new System.Drawing.Size(216, 21);
            this.Cbx_BedId.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Room ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Bed ID:";
            // 
            // Cbx_RoomId
            // 
            this.Cbx_RoomId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbx_RoomId.FormattingEnabled = true;
            this.Cbx_RoomId.Location = new System.Drawing.Point(115, 40);
            this.Cbx_RoomId.Name = "Cbx_RoomId";
            this.Cbx_RoomId.Size = new System.Drawing.Size(216, 21);
            this.Cbx_RoomId.TabIndex = 11;
            // 
            // NewBed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 108);
            this.Controls.Add(this.Cbx_RoomId);
            this.Controls.Add(this.Btn_Save);
            this.Controls.Add(this.Cbx_BedId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "NewBed";
            this.Text = "ViewBed";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.ComboBox Cbx_BedId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Cbx_RoomId;
    }
}