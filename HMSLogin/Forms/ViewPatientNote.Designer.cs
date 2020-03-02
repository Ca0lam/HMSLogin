namespace HMSLogin.Forms
{
	partial class ViewPatientNote
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
			this.LblPatientId = new System.Windows.Forms.Label();
			this.LblDate = new System.Windows.Forms.Label();
			this.BtnClose = new System.Windows.Forms.Button();
			this.TxtNoteBody = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// LblPatientId
			// 
			this.LblPatientId.AutoSize = true;
			this.LblPatientId.Location = new System.Drawing.Point(231, 38);
			this.LblPatientId.Name = "LblPatientId";
			this.LblPatientId.Size = new System.Drawing.Size(63, 13);
			this.LblPatientId.TabIndex = 7;
			this.LblPatientId.Text = "LblPatientId";
			// 
			// LblDate
			// 
			this.LblDate.AutoSize = true;
			this.LblDate.Location = new System.Drawing.Point(47, 38);
			this.LblDate.Name = "LblDate";
			this.LblDate.Size = new System.Drawing.Size(44, 13);
			this.LblDate.TabIndex = 6;
			this.LblDate.Text = "LblDate";
			// 
			// BtnClose
			// 
			this.BtnClose.Location = new System.Drawing.Point(246, 390);
			this.BtnClose.Name = "BtnClose";
			this.BtnClose.Size = new System.Drawing.Size(75, 23);
			this.BtnClose.TabIndex = 5;
			this.BtnClose.Text = "Save";
			this.BtnClose.UseVisualStyleBackColor = true;
			// 
			// TxtNoteBody
			// 
			this.TxtNoteBody.Location = new System.Drawing.Point(47, 80);
			this.TxtNoteBody.Multiline = true;
			this.TxtNoteBody.Name = "TxtNoteBody";
			this.TxtNoteBody.Size = new System.Drawing.Size(274, 284);
			this.TxtNoteBody.TabIndex = 4;
			// 
			// ViewPatientNote
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(368, 450);
			this.Controls.Add(this.LblPatientId);
			this.Controls.Add(this.LblDate);
			this.Controls.Add(this.BtnClose);
			this.Controls.Add(this.TxtNoteBody);
			this.Name = "ViewPatientNote";
			this.Text = "ViewPatientNote";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label LblPatientId;
		private System.Windows.Forms.Label LblDate;
		private System.Windows.Forms.Button BtnClose;
		private System.Windows.Forms.TextBox TxtNoteBody;
	}
}