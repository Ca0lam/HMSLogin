﻿namespace HMSLogin
{
	partial class FrmPatientDetails
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
			this.LblNOKName = new System.Windows.Forms.Label();
			this.LblPhoneNum = new System.Windows.Forms.Label();
			this.LblGener = new System.Windows.Forms.Label();
			this.LblDOB = new System.Windows.Forms.Label();
			this.LblSurename = new System.Windows.Forms.Label();
			this.LblForename = new System.Windows.Forms.Label();
			this.LblPatientID = new System.Windows.Forms.Label();
			this.lblTitle = new System.Windows.Forms.Label();
			this.TxtPatientID = new System.Windows.Forms.TextBox();
			this.TxtForename = new System.Windows.Forms.TextBox();
			this.TxtSurname = new System.Windows.Forms.TextBox();
			this.TxtDOBDay = new System.Windows.Forms.TextBox();
			this.TxtDOBMonth = new System.Windows.Forms.TextBox();
			this.TxtDOBYear = new System.Windows.Forms.TextBox();
			this.TxtPhoneNum = new System.Windows.Forms.TextBox();
			this.TxtNOKName = new System.Windows.Forms.TextBox();
			this.TxtNOKPhoneNum = new System.Windows.Forms.TextBox();
			this.LblNOKPhoneNum = new System.Windows.Forms.Label();
			this.TxtSearch = new System.Windows.Forms.TextBox();
			this.LblSearch = new System.Windows.Forms.Label();
			this.BtnSearch = new System.Windows.Forms.Button();
			this.GbxNOK = new System.Windows.Forms.GroupBox();
			this.LblDivider1 = new System.Windows.Forms.Label();
			this.LblDivider2 = new System.Windows.Forms.Label();
			this.RdoMale = new System.Windows.Forms.RadioButton();
			this.RdoFemale = new System.Windows.Forms.RadioButton();
			this.LstSearch = new System.Windows.Forms.ListBox();
			this.BtnUpdate = new System.Windows.Forms.Button();
			this.BtnSave = new System.Windows.Forms.Button();
			this.BtnNew = new System.Windows.Forms.Button();
			this.BtnCancel = new System.Windows.Forms.Button();
			this.TxtAddress = new System.Windows.Forms.TextBox();
			this.LblAddress = new System.Windows.Forms.Label();
			this.btnNewPatientNote = new System.Windows.Forms.Button();
			this.CbxPatientNotes = new System.Windows.Forms.ComboBox();
			this.BtnViewNote = new System.Windows.Forms.Button();
			this.GbxNOK.SuspendLayout();
			this.SuspendLayout();
			// 
			// LblNOKName
			// 
			this.LblNOKName.AutoSize = true;
			this.LblNOKName.Location = new System.Drawing.Point(6, 29);
			this.LblNOKName.Name = "LblNOKName";
			this.LblNOKName.Size = new System.Drawing.Size(38, 13);
			this.LblNOKName.TabIndex = 15;
			this.LblNOKName.Text = "Name:";
			// 
			// LblPhoneNum
			// 
			this.LblPhoneNum.AutoSize = true;
			this.LblPhoneNum.Location = new System.Drawing.Point(35, 214);
			this.LblPhoneNum.Name = "LblPhoneNum";
			this.LblPhoneNum.Size = new System.Drawing.Size(51, 13);
			this.LblPhoneNum.TabIndex = 14;
			this.LblPhoneNum.Text = "Phone #:";
			// 
			// LblGener
			// 
			this.LblGener.AutoSize = true;
			this.LblGener.Location = new System.Drawing.Point(35, 186);
			this.LblGener.Name = "LblGener";
			this.LblGener.Size = new System.Drawing.Size(45, 13);
			this.LblGener.TabIndex = 13;
			this.LblGener.Text = "Gender:";
			// 
			// LblDOB
			// 
			this.LblDOB.AutoSize = true;
			this.LblDOB.Location = new System.Drawing.Point(35, 157);
			this.LblDOB.Name = "LblDOB";
			this.LblDOB.Size = new System.Drawing.Size(33, 13);
			this.LblDOB.TabIndex = 12;
			this.LblDOB.Text = "DOB:";
			// 
			// LblSurename
			// 
			this.LblSurename.AutoSize = true;
			this.LblSurename.Location = new System.Drawing.Point(35, 129);
			this.LblSurename.Name = "LblSurename";
			this.LblSurename.Size = new System.Drawing.Size(52, 13);
			this.LblSurename.TabIndex = 11;
			this.LblSurename.Text = "Surname:";
			// 
			// LblForename
			// 
			this.LblForename.AutoSize = true;
			this.LblForename.Location = new System.Drawing.Point(35, 100);
			this.LblForename.Name = "LblForename";
			this.LblForename.Size = new System.Drawing.Size(51, 13);
			this.LblForename.TabIndex = 10;
			this.LblForename.Text = "Forname:";
			// 
			// LblPatientID
			// 
			this.LblPatientID.AutoSize = true;
			this.LblPatientID.Location = new System.Drawing.Point(35, 71);
			this.LblPatientID.Name = "LblPatientID";
			this.LblPatientID.Size = new System.Drawing.Size(57, 13);
			this.LblPatientID.TabIndex = 9;
			this.LblPatientID.Text = "Patient ID:";
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle.Location = new System.Drawing.Point(32, 22);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(190, 31);
			this.lblTitle.TabIndex = 8;
			this.lblTitle.Text = "Patient Details";
			// 
			// TxtPatientID
			// 
			this.TxtPatientID.Enabled = false;
			this.TxtPatientID.Location = new System.Drawing.Point(110, 68);
			this.TxtPatientID.Name = "TxtPatientID";
			this.TxtPatientID.Size = new System.Drawing.Size(165, 20);
			this.TxtPatientID.TabIndex = 16;
			// 
			// TxtForename
			// 
			this.TxtForename.Location = new System.Drawing.Point(110, 97);
			this.TxtForename.Name = "TxtForename";
			this.TxtForename.Size = new System.Drawing.Size(165, 20);
			this.TxtForename.TabIndex = 17;
			// 
			// TxtSurname
			// 
			this.TxtSurname.Location = new System.Drawing.Point(110, 126);
			this.TxtSurname.Name = "TxtSurname";
			this.TxtSurname.Size = new System.Drawing.Size(165, 20);
			this.TxtSurname.TabIndex = 18;
			// 
			// TxtDOBDay
			// 
			this.TxtDOBDay.Location = new System.Drawing.Point(110, 154);
			this.TxtDOBDay.Name = "TxtDOBDay";
			this.TxtDOBDay.Size = new System.Drawing.Size(33, 20);
			this.TxtDOBDay.TabIndex = 19;
			// 
			// TxtDOBMonth
			// 
			this.TxtDOBMonth.Location = new System.Drawing.Point(162, 154);
			this.TxtDOBMonth.Name = "TxtDOBMonth";
			this.TxtDOBMonth.Size = new System.Drawing.Size(33, 20);
			this.TxtDOBMonth.TabIndex = 20;
			// 
			// TxtDOBYear
			// 
			this.TxtDOBYear.Location = new System.Drawing.Point(215, 154);
			this.TxtDOBYear.Name = "TxtDOBYear";
			this.TxtDOBYear.Size = new System.Drawing.Size(60, 20);
			this.TxtDOBYear.TabIndex = 21;
			// 
			// TxtPhoneNum
			// 
			this.TxtPhoneNum.Location = new System.Drawing.Point(110, 211);
			this.TxtPhoneNum.Name = "TxtPhoneNum";
			this.TxtPhoneNum.Size = new System.Drawing.Size(165, 20);
			this.TxtPhoneNum.TabIndex = 22;
			// 
			// TxtNOKName
			// 
			this.TxtNOKName.Location = new System.Drawing.Point(68, 26);
			this.TxtNOKName.Name = "TxtNOKName";
			this.TxtNOKName.Size = new System.Drawing.Size(165, 20);
			this.TxtNOKName.TabIndex = 23;
			// 
			// TxtNOKPhoneNum
			// 
			this.TxtNOKPhoneNum.Location = new System.Drawing.Point(68, 58);
			this.TxtNOKPhoneNum.Name = "TxtNOKPhoneNum";
			this.TxtNOKPhoneNum.Size = new System.Drawing.Size(165, 20);
			this.TxtNOKPhoneNum.TabIndex = 25;
			// 
			// LblNOKPhoneNum
			// 
			this.LblNOKPhoneNum.AutoSize = true;
			this.LblNOKPhoneNum.Location = new System.Drawing.Point(6, 61);
			this.LblNOKPhoneNum.Name = "LblNOKPhoneNum";
			this.LblNOKPhoneNum.Size = new System.Drawing.Size(51, 13);
			this.LblNOKPhoneNum.TabIndex = 24;
			this.LblNOKPhoneNum.Text = "Phone #:";
			// 
			// TxtSearch
			// 
			this.TxtSearch.Location = new System.Drawing.Point(363, 36);
			this.TxtSearch.Name = "TxtSearch";
			this.TxtSearch.Size = new System.Drawing.Size(165, 20);
			this.TxtSearch.TabIndex = 27;
			this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
			// 
			// LblSearch
			// 
			this.LblSearch.AutoSize = true;
			this.LblSearch.Location = new System.Drawing.Point(313, 40);
			this.LblSearch.Name = "LblSearch";
			this.LblSearch.Size = new System.Drawing.Size(44, 13);
			this.LblSearch.TabIndex = 26;
			this.LblSearch.Text = "Search:";
			// 
			// BtnSearch
			// 
			this.BtnSearch.Location = new System.Drawing.Point(534, 34);
			this.BtnSearch.Name = "BtnSearch";
			this.BtnSearch.Size = new System.Drawing.Size(37, 23);
			this.BtnSearch.TabIndex = 28;
			this.BtnSearch.Text = "--(_)";
			this.BtnSearch.UseVisualStyleBackColor = true;
			this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
			// 
			// GbxNOK
			// 
			this.GbxNOK.Controls.Add(this.LblNOKName);
			this.GbxNOK.Controls.Add(this.TxtNOKName);
			this.GbxNOK.Controls.Add(this.LblNOKPhoneNum);
			this.GbxNOK.Controls.Add(this.TxtNOKPhoneNum);
			this.GbxNOK.Location = new System.Drawing.Point(316, 74);
			this.GbxNOK.Name = "GbxNOK";
			this.GbxNOK.Size = new System.Drawing.Size(255, 100);
			this.GbxNOK.TabIndex = 29;
			this.GbxNOK.TabStop = false;
			this.GbxNOK.Text = "NOK";
			// 
			// LblDivider1
			// 
			this.LblDivider1.AutoSize = true;
			this.LblDivider1.Location = new System.Drawing.Point(146, 158);
			this.LblDivider1.Name = "LblDivider1";
			this.LblDivider1.Size = new System.Drawing.Size(12, 13);
			this.LblDivider1.TabIndex = 30;
			this.LblDivider1.Text = "/";
			// 
			// LblDivider2
			// 
			this.LblDivider2.AutoSize = true;
			this.LblDivider2.Location = new System.Drawing.Point(199, 157);
			this.LblDivider2.Name = "LblDivider2";
			this.LblDivider2.Size = new System.Drawing.Size(12, 13);
			this.LblDivider2.TabIndex = 31;
			this.LblDivider2.Text = "/";
			// 
			// RdoMale
			// 
			this.RdoMale.AutoSize = true;
			this.RdoMale.Location = new System.Drawing.Point(130, 186);
			this.RdoMale.Name = "RdoMale";
			this.RdoMale.Size = new System.Drawing.Size(48, 17);
			this.RdoMale.TabIndex = 32;
			this.RdoMale.TabStop = true;
			this.RdoMale.Text = "Male";
			this.RdoMale.UseVisualStyleBackColor = true;
			// 
			// RdoFemale
			// 
			this.RdoFemale.AutoSize = true;
			this.RdoFemale.Location = new System.Drawing.Point(202, 186);
			this.RdoFemale.Name = "RdoFemale";
			this.RdoFemale.Size = new System.Drawing.Size(59, 17);
			this.RdoFemale.TabIndex = 33;
			this.RdoFemale.TabStop = true;
			this.RdoFemale.Text = "Female";
			this.RdoFemale.UseVisualStyleBackColor = true;
			// 
			// LstSearch
			// 
			this.LstSearch.FormattingEnabled = true;
			this.LstSearch.Location = new System.Drawing.Point(591, 36);
			this.LstSearch.Name = "LstSearch";
			this.LstSearch.Size = new System.Drawing.Size(154, 95);
			this.LstSearch.TabIndex = 34;
			this.LstSearch.SelectedValueChanged += new System.EventHandler(this.LstSearch_SelectedValueChanged);
			// 
			// BtnUpdate
			// 
			this.BtnUpdate.Location = new System.Drawing.Point(397, 214);
			this.BtnUpdate.Name = "BtnUpdate";
			this.BtnUpdate.Size = new System.Drawing.Size(57, 23);
			this.BtnUpdate.TabIndex = 35;
			this.BtnUpdate.Text = "Update";
			this.BtnUpdate.UseVisualStyleBackColor = true;
			this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
			// 
			// BtnSave
			// 
			this.BtnSave.Location = new System.Drawing.Point(523, 214);
			this.BtnSave.Name = "BtnSave";
			this.BtnSave.Size = new System.Drawing.Size(53, 50);
			this.BtnSave.TabIndex = 36;
			this.BtnSave.Text = "Save";
			this.BtnSave.UseVisualStyleBackColor = true;
			this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
			// 
			// BtnNew
			// 
			this.BtnNew.Location = new System.Drawing.Point(460, 214);
			this.BtnNew.Name = "BtnNew";
			this.BtnNew.Size = new System.Drawing.Size(57, 23);
			this.BtnNew.TabIndex = 37;
			this.BtnNew.Text = "New";
			this.BtnNew.UseVisualStyleBackColor = true;
			// 
			// BtnCancel
			// 
			this.BtnCancel.Location = new System.Drawing.Point(397, 241);
			this.BtnCancel.Name = "BtnCancel";
			this.BtnCancel.Size = new System.Drawing.Size(120, 23);
			this.BtnCancel.TabIndex = 38;
			this.BtnCancel.Text = "Cancel";
			this.BtnCancel.UseVisualStyleBackColor = true;
			// 
			// TxtAddress
			// 
			this.TxtAddress.Location = new System.Drawing.Point(110, 242);
			this.TxtAddress.Multiline = true;
			this.TxtAddress.Name = "TxtAddress";
			this.TxtAddress.Size = new System.Drawing.Size(165, 69);
			this.TxtAddress.TabIndex = 40;
			// 
			// LblAddress
			// 
			this.LblAddress.AutoSize = true;
			this.LblAddress.Location = new System.Drawing.Point(35, 245);
			this.LblAddress.Name = "LblAddress";
			this.LblAddress.Size = new System.Drawing.Size(48, 13);
			this.LblAddress.TabIndex = 39;
			this.LblAddress.Text = "Address:";
			// 
			// btnNewPatientNote
			// 
			this.btnNewPatientNote.Location = new System.Drawing.Point(442, 337);
			this.btnNewPatientNote.Name = "btnNewPatientNote";
			this.btnNewPatientNote.Size = new System.Drawing.Size(75, 23);
			this.btnNewPatientNote.TabIndex = 41;
			this.btnNewPatientNote.Text = "Add Note";
			this.btnNewPatientNote.UseVisualStyleBackColor = true;
			this.btnNewPatientNote.Click += new System.EventHandler(this.btnNewPatientNote_Click);
			// 
			// CbxPatientNotes
			// 
			this.CbxPatientNotes.FormattingEnabled = true;
			this.CbxPatientNotes.Location = new System.Drawing.Point(325, 310);
			this.CbxPatientNotes.Name = "CbxPatientNotes";
			this.CbxPatientNotes.Size = new System.Drawing.Size(192, 21);
			this.CbxPatientNotes.TabIndex = 42;
			// 
			// BtnViewNote
			// 
			this.BtnViewNote.Location = new System.Drawing.Point(325, 337);
			this.BtnViewNote.Name = "BtnViewNote";
			this.BtnViewNote.Size = new System.Drawing.Size(75, 23);
			this.BtnViewNote.TabIndex = 43;
			this.BtnViewNote.Text = "View Note";
			this.BtnViewNote.UseVisualStyleBackColor = true;
			this.BtnViewNote.Click += new System.EventHandler(this.BtnViewNote_Click);
			// 
			// FrmPatientDetails
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.BtnViewNote);
			this.Controls.Add(this.CbxPatientNotes);
			this.Controls.Add(this.btnNewPatientNote);
			this.Controls.Add(this.TxtAddress);
			this.Controls.Add(this.LblAddress);
			this.Controls.Add(this.BtnCancel);
			this.Controls.Add(this.BtnNew);
			this.Controls.Add(this.BtnSave);
			this.Controls.Add(this.BtnUpdate);
			this.Controls.Add(this.LstSearch);
			this.Controls.Add(this.RdoFemale);
			this.Controls.Add(this.RdoMale);
			this.Controls.Add(this.LblDivider2);
			this.Controls.Add(this.LblDivider1);
			this.Controls.Add(this.GbxNOK);
			this.Controls.Add(this.BtnSearch);
			this.Controls.Add(this.TxtSearch);
			this.Controls.Add(this.LblSearch);
			this.Controls.Add(this.TxtPhoneNum);
			this.Controls.Add(this.TxtDOBYear);
			this.Controls.Add(this.TxtDOBMonth);
			this.Controls.Add(this.TxtDOBDay);
			this.Controls.Add(this.TxtSurname);
			this.Controls.Add(this.TxtForename);
			this.Controls.Add(this.TxtPatientID);
			this.Controls.Add(this.LblPhoneNum);
			this.Controls.Add(this.LblGener);
			this.Controls.Add(this.LblDOB);
			this.Controls.Add(this.LblSurename);
			this.Controls.Add(this.LblForename);
			this.Controls.Add(this.LblPatientID);
			this.Controls.Add(this.lblTitle);
			this.Name = "FrmPatientDetails";
			this.Text = "PatientDetails";
			this.GbxNOK.ResumeLayout(false);
			this.GbxNOK.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label LblNOKName;
		private System.Windows.Forms.Label LblPhoneNum;
		private System.Windows.Forms.Label LblGener;
		private System.Windows.Forms.Label LblDOB;
		private System.Windows.Forms.Label LblSurename;
		private System.Windows.Forms.Label LblForename;
		private System.Windows.Forms.Label LblPatientID;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.TextBox TxtPatientID;
		private System.Windows.Forms.TextBox TxtForename;
		private System.Windows.Forms.TextBox TxtSurname;
		private System.Windows.Forms.TextBox TxtDOBDay;
		private System.Windows.Forms.TextBox TxtDOBMonth;
		private System.Windows.Forms.TextBox TxtDOBYear;
		private System.Windows.Forms.TextBox TxtPhoneNum;
		private System.Windows.Forms.TextBox TxtNOKName;
		private System.Windows.Forms.TextBox TxtNOKPhoneNum;
		private System.Windows.Forms.Label LblNOKPhoneNum;
		private System.Windows.Forms.TextBox TxtSearch;
		private System.Windows.Forms.Label LblSearch;
		private System.Windows.Forms.Button BtnSearch;
		private System.Windows.Forms.GroupBox GbxNOK;
		private System.Windows.Forms.Label LblDivider1;
		private System.Windows.Forms.Label LblDivider2;
		private System.Windows.Forms.RadioButton RdoMale;
		private System.Windows.Forms.RadioButton RdoFemale;
		private System.Windows.Forms.ListBox LstSearch;
		private System.Windows.Forms.Button BtnUpdate;
		private System.Windows.Forms.Button BtnSave;
		private System.Windows.Forms.Button BtnNew;
		private System.Windows.Forms.Button BtnCancel;
		private System.Windows.Forms.TextBox TxtAddress;
		private System.Windows.Forms.Label LblAddress;
		private System.Windows.Forms.Button btnNewPatientNote;
		private System.Windows.Forms.ComboBox CbxPatientNotes;
		private System.Windows.Forms.Button BtnViewNote;
	}
}