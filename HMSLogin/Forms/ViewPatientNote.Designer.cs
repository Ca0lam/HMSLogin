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
			this.LblViewNote = new System.Windows.Forms.Label();
			this.LblDateLbl = new System.Windows.Forms.Label();
			this.LblIdLbl = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// LblPatientId
			// 
			this.LblPatientId.AutoSize = true;
			this.LblPatientId.Location = new System.Drawing.Point(232, 72);
			this.LblPatientId.Name = "LblPatientId";
			this.LblPatientId.Size = new System.Drawing.Size(30, 13);
			this.LblPatientId.TabIndex = 7;
			this.LblPatientId.Text = "LblId";
			// 
			// LblDate
			// 
			this.LblDate.AutoSize = true;
			this.LblDate.Location = new System.Drawing.Point(86, 72);
			this.LblDate.Name = "LblDate";
			this.LblDate.Size = new System.Drawing.Size(44, 13);
			this.LblDate.TabIndex = 6;
			this.LblDate.Text = "LblDate";
			// 
			// BtnClose
			// 
			this.BtnClose.Location = new System.Drawing.Point(246, 404);
			this.BtnClose.Name = "BtnClose";
			this.BtnClose.Size = new System.Drawing.Size(75, 23);
			this.BtnClose.TabIndex = 5;
			this.BtnClose.Text = "Close";
			this.BtnClose.UseVisualStyleBackColor = true;
			this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
			// 
			// TxtNoteBody
			// 
			this.TxtNoteBody.Location = new System.Drawing.Point(47, 100);
			this.TxtNoteBody.Multiline = true;
			this.TxtNoteBody.Name = "TxtNoteBody";
			this.TxtNoteBody.Size = new System.Drawing.Size(274, 284);
			this.TxtNoteBody.TabIndex = 4;
			// 
			// LblViewNote
			// 
			this.LblViewNote.AutoSize = true;
			this.LblViewNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblViewNote.Location = new System.Drawing.Point(45, 29);
			this.LblViewNote.Name = "LblViewNote";
			this.LblViewNote.Size = new System.Drawing.Size(133, 29);
			this.LblViewNote.TabIndex = 8;
			this.LblViewNote.Text = "View Note";
			// 
			// LblDateLbl
			// 
			this.LblDateLbl.AutoSize = true;
			this.LblDateLbl.Location = new System.Drawing.Point(47, 72);
			this.LblDateLbl.Name = "LblDateLbl";
			this.LblDateLbl.Size = new System.Drawing.Size(33, 13);
			this.LblDateLbl.TabIndex = 9;
			this.LblDateLbl.Text = "Date:";
			// 
			// LblIdLbl
			// 
			this.LblIdLbl.AutoSize = true;
			this.LblIdLbl.Location = new System.Drawing.Point(232, 72);
			this.LblIdLbl.Name = "LblIdLbl";
			this.LblIdLbl.Size = new System.Drawing.Size(55, 13);
			this.LblIdLbl.TabIndex = 10;
			this.LblIdLbl.Text = "Patient Id:";
			// 
			// ViewPatientNote
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(368, 450);
			this.Controls.Add(this.LblIdLbl);
			this.Controls.Add(this.LblDateLbl);
			this.Controls.Add(this.LblViewNote);
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
		private System.Windows.Forms.Label LblViewNote;
		private System.Windows.Forms.Label LblDateLbl;
		private System.Windows.Forms.Label LblIdLbl;
	}
}