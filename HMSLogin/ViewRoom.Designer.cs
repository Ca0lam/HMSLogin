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
            this.label1 = new System.Windows.Forms.Label();
            this.Cbx_WardId = new System.Windows.Forms.ComboBox();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.Cbx_RoomId = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Cbx_RoomType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Room Type:";
            // 
            // Cbx_WardId
            // 
            this.Cbx_WardId.FormattingEnabled = true;
            this.Cbx_WardId.Location = new System.Drawing.Point(115, 36);
            this.Cbx_WardId.Name = "Cbx_WardId";
            this.Cbx_WardId.Size = new System.Drawing.Size(216, 21);
            this.Cbx_WardId.TabIndex = 18;
            // 
            // Btn_Save
            // 
            this.Btn_Save.Location = new System.Drawing.Point(256, 109);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(75, 23);
            this.Btn_Save.TabIndex = 17;
            this.Btn_Save.Text = "Save";
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Cbx_RoomId
            // 
            this.Cbx_RoomId.FormattingEnabled = true;
            this.Cbx_RoomId.Location = new System.Drawing.Point(115, 9);
            this.Cbx_RoomId.Name = "Cbx_RoomId";
            this.Cbx_RoomId.Size = new System.Drawing.Size(216, 21);
            this.Cbx_RoomId.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Ward ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Room ID:";
            // 
            // Cbx_RoomType
            // 
            this.Cbx_RoomType.FormattingEnabled = true;
            this.Cbx_RoomType.Location = new System.Drawing.Point(115, 63);
            this.Cbx_RoomType.Name = "Cbx_RoomType";
            this.Cbx_RoomType.Size = new System.Drawing.Size(216, 21);
            this.Cbx_RoomType.TabIndex = 20;
            // 
            // ViewRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 160);
            this.Controls.Add(this.Cbx_RoomType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cbx_WardId);
            this.Controls.Add(this.Btn_Save);
            this.Controls.Add(this.Cbx_RoomId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "ViewRoom";
            this.Text = "ViewRoom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Cbx_WardId;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.ComboBox Cbx_RoomId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Cbx_RoomType;
    }
}