namespace HMSLogin
{
    partial class HMSBillingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HMSBillingForm));
            this.LblTitle = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.LblId = new System.Windows.Forms.Label();
            this.LblDate = new System.Windows.Forms.Label();
            this.LblPatientId = new System.Windows.Forms.Label();
            this.LblRoomCharge = new System.Windows.Forms.Label();
            this.LblDoctorsFee = new System.Windows.Forms.Label();
            this.LblNote = new System.Windows.Forms.Label();
            this.LblMiscFee = new System.Windows.Forms.Label();
            this.LblTotalFee = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.TxtDateMonth = new System.Windows.Forms.TextBox();
            this.TxtPatientId = new System.Windows.Forms.TextBox();
            this.TxtRoomCharge = new System.Windows.Forms.TextBox();
            this.TxtDoctorsFee = new System.Windows.Forms.TextBox();
            this.TxtNote = new System.Windows.Forms.TextBox();
            this.TxtMiscFee = new System.Windows.Forms.TextBox();
            this.TxtTotalFee = new System.Windows.Forms.TextBox();
            this.BtnPrint = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.TxtDateYear = new System.Windows.Forms.TextBox();
            this.TxtDateDay = new System.Windows.Forms.TextBox();
            this.LblDateSlash1 = new System.Windows.Forms.Label();
            this.LblDateSlash2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.Location = new System.Drawing.Point(13, 13);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(93, 31);
            this.LblTitle.TabIndex = 0;
            this.LblTitle.Text = "Billing";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(45, 61);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(35, 13);
            this.LblName.TabIndex = 1;
            this.LblName.Text = "Name";
            // 
            // LblId
            // 
            this.LblId.AutoSize = true;
            this.LblId.Location = new System.Drawing.Point(64, 87);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(16, 13);
            this.LblId.TabIndex = 2;
            this.LblId.Text = "Id";
            // 
            // LblDate
            // 
            this.LblDate.AutoSize = true;
            this.LblDate.Location = new System.Drawing.Point(50, 113);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(30, 13);
            this.LblDate.TabIndex = 3;
            this.LblDate.Text = "Date";
            // 
            // LblPatientId
            // 
            this.LblPatientId.AutoSize = true;
            this.LblPatientId.Location = new System.Drawing.Point(30, 139);
            this.LblPatientId.Name = "LblPatientId";
            this.LblPatientId.Size = new System.Drawing.Size(52, 13);
            this.LblPatientId.TabIndex = 4;
            this.LblPatientId.Text = "Patient Id";
            // 
            // LblRoomCharge
            // 
            this.LblRoomCharge.AutoSize = true;
            this.LblRoomCharge.Location = new System.Drawing.Point(8, 165);
            this.LblRoomCharge.Name = "LblRoomCharge";
            this.LblRoomCharge.Size = new System.Drawing.Size(72, 13);
            this.LblRoomCharge.TabIndex = 5;
            this.LblRoomCharge.Text = "Room Charge";
            // 
            // LblDoctorsFee
            // 
            this.LblDoctorsFee.AutoSize = true;
            this.LblDoctorsFee.Location = new System.Drawing.Point(15, 191);
            this.LblDoctorsFee.Name = "LblDoctorsFee";
            this.LblDoctorsFee.Size = new System.Drawing.Size(65, 13);
            this.LblDoctorsFee.TabIndex = 6;
            this.LblDoctorsFee.Text = "Doctors Fee";
            // 
            // LblNote
            // 
            this.LblNote.AutoSize = true;
            this.LblNote.Location = new System.Drawing.Point(50, 217);
            this.LblNote.Name = "LblNote";
            this.LblNote.Size = new System.Drawing.Size(30, 13);
            this.LblNote.TabIndex = 7;
            this.LblNote.Text = "Note";
            // 
            // LblMiscFee
            // 
            this.LblMiscFee.AutoSize = true;
            this.LblMiscFee.Location = new System.Drawing.Point(30, 295);
            this.LblMiscFee.Name = "LblMiscFee";
            this.LblMiscFee.Size = new System.Drawing.Size(50, 13);
            this.LblMiscFee.TabIndex = 8;
            this.LblMiscFee.Text = "Misc Fee";
            // 
            // LblTotalFee
            // 
            this.LblTotalFee.AutoSize = true;
            this.LblTotalFee.Location = new System.Drawing.Point(28, 321);
            this.LblTotalFee.Name = "LblTotalFee";
            this.LblTotalFee.Size = new System.Drawing.Size(52, 13);
            this.LblTotalFee.TabIndex = 9;
            this.LblTotalFee.Text = "Total Fee";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(86, 58);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(251, 20);
            this.TxtName.TabIndex = 10;
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(86, 84);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(251, 20);
            this.TxtId.TabIndex = 11;
            // 
            // TxtDateMonth
            // 
            this.TxtDateMonth.Location = new System.Drawing.Point(119, 110);
            this.TxtDateMonth.Name = "TxtDateMonth";
            this.TxtDateMonth.Size = new System.Drawing.Size(19, 20);
            this.TxtDateMonth.TabIndex = 12;
            // 
            // TxtPatientId
            // 
            this.TxtPatientId.Location = new System.Drawing.Point(86, 136);
            this.TxtPatientId.Name = "TxtPatientId";
            this.TxtPatientId.Size = new System.Drawing.Size(251, 20);
            this.TxtPatientId.TabIndex = 13;
            // 
            // TxtRoomCharge
            // 
            this.TxtRoomCharge.Location = new System.Drawing.Point(86, 162);
            this.TxtRoomCharge.Name = "TxtRoomCharge";
            this.TxtRoomCharge.Size = new System.Drawing.Size(58, 20);
            this.TxtRoomCharge.TabIndex = 14;
            // 
            // TxtDoctorsFee
            // 
            this.TxtDoctorsFee.Location = new System.Drawing.Point(86, 188);
            this.TxtDoctorsFee.Name = "TxtDoctorsFee";
            this.TxtDoctorsFee.Size = new System.Drawing.Size(58, 20);
            this.TxtDoctorsFee.TabIndex = 15;
            this.TxtDoctorsFee.TextChanged += new System.EventHandler(this.TextBox6_TextChanged);
            // 
            // TxtNote
            // 
            this.TxtNote.Location = new System.Drawing.Point(86, 214);
            this.TxtNote.Multiline = true;
            this.TxtNote.Name = "TxtNote";
            this.TxtNote.Size = new System.Drawing.Size(251, 72);
            this.TxtNote.TabIndex = 16;
            // 
            // TxtMiscFee
            // 
            this.TxtMiscFee.Location = new System.Drawing.Point(86, 292);
            this.TxtMiscFee.Name = "TxtMiscFee";
            this.TxtMiscFee.Size = new System.Drawing.Size(58, 20);
            this.TxtMiscFee.TabIndex = 17;
            // 
            // TxtTotalFee
            // 
            this.TxtTotalFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotalFee.Location = new System.Drawing.Point(86, 318);
            this.TxtTotalFee.Multiline = true;
            this.TxtTotalFee.Name = "TxtTotalFee";
            this.TxtTotalFee.Size = new System.Drawing.Size(251, 72);
            this.TxtTotalFee.TabIndex = 18;
            // 
            // BtnPrint
            // 
            this.BtnPrint.Location = new System.Drawing.Point(12, 396);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Size = new System.Drawing.Size(75, 23);
            this.BtnPrint.TabIndex = 19;
            this.BtnPrint.Text = "Print";
            this.BtnPrint.UseVisualStyleBackColor = true;
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(93, 396);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 20;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(262, 396);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(75, 23);
            this.BtnClose.TabIndex = 21;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // TxtDateYear
            // 
            this.TxtDateYear.Location = new System.Drawing.Point(151, 110);
            this.TxtDateYear.Name = "TxtDateYear";
            this.TxtDateYear.Size = new System.Drawing.Size(19, 20);
            this.TxtDateYear.TabIndex = 22;
            // 
            // TxtDateDay
            // 
            this.TxtDateDay.Location = new System.Drawing.Point(86, 110);
            this.TxtDateDay.Name = "TxtDateDay";
            this.TxtDateDay.Size = new System.Drawing.Size(19, 20);
            this.TxtDateDay.TabIndex = 23;
            // 
            // LblDateSlash1
            // 
            this.LblDateSlash1.AutoSize = true;
            this.LblDateSlash1.Location = new System.Drawing.Point(106, 113);
            this.LblDateSlash1.Name = "LblDateSlash1";
            this.LblDateSlash1.Size = new System.Drawing.Size(12, 13);
            this.LblDateSlash1.TabIndex = 24;
            this.LblDateSlash1.Text = "/";
            // 
            // LblDateSlash2
            // 
            this.LblDateSlash2.AutoSize = true;
            this.LblDateSlash2.Location = new System.Drawing.Point(139, 113);
            this.LblDateSlash2.Name = "LblDateSlash2";
            this.LblDateSlash2.Size = new System.Drawing.Size(12, 13);
            this.LblDateSlash2.TabIndex = 25;
            this.LblDateSlash2.Text = "/";
            // 
            // HMSBillingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 433);
            this.Controls.Add(this.LblDateSlash2);
            this.Controls.Add(this.LblDateSlash1);
            this.Controls.Add(this.TxtDateDay);
            this.Controls.Add(this.TxtDateYear);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnPrint);
            this.Controls.Add(this.TxtTotalFee);
            this.Controls.Add(this.TxtMiscFee);
            this.Controls.Add(this.TxtNote);
            this.Controls.Add(this.TxtDoctorsFee);
            this.Controls.Add(this.TxtRoomCharge);
            this.Controls.Add(this.TxtPatientId);
            this.Controls.Add(this.TxtDateMonth);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.LblTotalFee);
            this.Controls.Add(this.LblMiscFee);
            this.Controls.Add(this.LblNote);
            this.Controls.Add(this.LblDoctorsFee);
            this.Controls.Add(this.LblRoomCharge);
            this.Controls.Add(this.LblPatientId);
            this.Controls.Add(this.LblDate);
            this.Controls.Add(this.LblId);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.LblTitle);
            this.Name = "HMSBillingForm";
            this.Text = "Billing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblId;
        private System.Windows.Forms.Label LblDate;
        private System.Windows.Forms.Label LblPatientId;
        private System.Windows.Forms.Label LblRoomCharge;
        private System.Windows.Forms.Label LblDoctorsFee;
        private System.Windows.Forms.Label LblNote;
        private System.Windows.Forms.Label LblMiscFee;
        private System.Windows.Forms.Label LblTotalFee;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.TextBox TxtDateMonth;
        private System.Windows.Forms.TextBox TxtPatientId;
        private System.Windows.Forms.TextBox TxtRoomCharge;
        private System.Windows.Forms.TextBox TxtDoctorsFee;
        private System.Windows.Forms.TextBox TxtNote;
        private System.Windows.Forms.TextBox TxtMiscFee;
        private System.Windows.Forms.TextBox TxtTotalFee;
        private System.Windows.Forms.Button BtnPrint;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.TextBox TxtDateYear;
        private System.Windows.Forms.TextBox TxtDateDay;
        private System.Windows.Forms.Label LblDateSlash1;
        private System.Windows.Forms.Label LblDateSlash2;
    }
}