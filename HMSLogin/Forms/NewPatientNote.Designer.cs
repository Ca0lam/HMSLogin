namespace HMSLogin
{
	partial class NewPatientNote
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
			this.TxtNoteBody = new System.Windows.Forms.TextBox();
			this.BtnSave = new System.Windows.Forms.Button();
			this.LblDate = new System.Windows.Forms.Label();
			this.LblPatientId = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// TxtNoteBody
			// 
			this.TxtNoteBody.Location = new System.Drawing.Point(53, 89);
			this.TxtNoteBody.Multiline = true;
			this.TxtNoteBody.Name = "TxtNoteBody";
			this.TxtNoteBody.Size = new System.Drawing.Size(274, 284);
			this.TxtNoteBody.TabIndex = 0;
			// 
			// BtnSave
			// 
			this.BtnSave.Location = new System.Drawing.Point(252, 399);
			this.BtnSave.Name = "BtnSave";
			this.BtnSave.Size = new System.Drawing.Size(75, 23);
			this.BtnSave.TabIndex = 1;
			this.BtnSave.Text = "Save";
			this.BtnSave.UseVisualStyleBackColor = true;
			this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
			// 
			// LblDate
			// 
			this.LblDate.AutoSize = true;
			this.LblDate.Location = new System.Drawing.Point(53, 47);
			this.LblDate.Name = "LblDate";
			this.LblDate.Size = new System.Drawing.Size(44, 13);
			this.LblDate.TabIndex = 2;
			this.LblDate.Text = "LblDate";
			// 
			// LblPatientId
			// 
			this.LblPatientId.AutoSize = true;
			this.LblPatientId.Location = new System.Drawing.Point(237, 47);
			this.LblPatientId.Name = "LblPatientId";
			this.LblPatientId.Size = new System.Drawing.Size(63, 13);
			this.LblPatientId.TabIndex = 3;
			this.LblPatientId.Text = "LblPatientId";
			// 
			// PatientNotes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(377, 458);
			this.Controls.Add(this.LblPatientId);
			this.Controls.Add(this.LblDate);
			this.Controls.Add(this.BtnSave);
			this.Controls.Add(this.TxtNoteBody);
			this.Name = "PatientNotes";
			this.Text = "PatientNotes";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox TxtNoteBody;
		private System.Windows.Forms.Button BtnSave;
		private System.Windows.Forms.Label LblDate;
		private System.Windows.Forms.Label LblPatientId;
	}
}