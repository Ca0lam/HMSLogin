namespace HMSLogin
{
    partial class DoctorSearchForm
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
            this.grpSearchDoctor = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtDocDeptSearch = new System.Windows.Forms.TextBox();
            this.txtDocSurnameSearch = new System.Windows.Forms.TextBox();
            this.txtDocIdSearch = new System.Windows.Forms.TextBox();
            this.lblDocDeptSearch = new System.Windows.Forms.Label();
            this.lblDocSurnameSearch = new System.Windows.Forms.Label();
            this.lblDocIdSearch = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lblList = new System.Windows.Forms.Label();
            this.grpSearchDoctor.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSearchDoctor
            // 
            this.grpSearchDoctor.Controls.Add(this.btnSearch);
            this.grpSearchDoctor.Controls.Add(this.txtDocDeptSearch);
            this.grpSearchDoctor.Controls.Add(this.txtDocSurnameSearch);
            this.grpSearchDoctor.Controls.Add(this.txtDocIdSearch);
            this.grpSearchDoctor.Controls.Add(this.lblDocDeptSearch);
            this.grpSearchDoctor.Controls.Add(this.lblDocSurnameSearch);
            this.grpSearchDoctor.Controls.Add(this.lblDocIdSearch);
            this.grpSearchDoctor.Location = new System.Drawing.Point(87, 41);
            this.grpSearchDoctor.Name = "grpSearchDoctor";
            this.grpSearchDoctor.Size = new System.Drawing.Size(797, 149);
            this.grpSearchDoctor.TabIndex = 0;
            this.grpSearchDoctor.TabStop = false;
            this.grpSearchDoctor.Text = "search for doctor";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(599, 63);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtDocDeptSearch
            // 
            this.txtDocDeptSearch.Location = new System.Drawing.Point(308, 108);
            this.txtDocDeptSearch.Name = "txtDocDeptSearch";
            this.txtDocDeptSearch.Size = new System.Drawing.Size(167, 20);
            this.txtDocDeptSearch.TabIndex = 5;
            // 
            // txtDocSurnameSearch
            // 
            this.txtDocSurnameSearch.Location = new System.Drawing.Point(308, 67);
            this.txtDocSurnameSearch.Name = "txtDocSurnameSearch";
            this.txtDocSurnameSearch.Size = new System.Drawing.Size(167, 20);
            this.txtDocSurnameSearch.TabIndex = 4;
            // 
            // txtDocIdSearch
            // 
            this.txtDocIdSearch.Location = new System.Drawing.Point(308, 32);
            this.txtDocIdSearch.Name = "txtDocIdSearch";
            this.txtDocIdSearch.Size = new System.Drawing.Size(167, 20);
            this.txtDocIdSearch.TabIndex = 3;
            // 
            // lblDocDeptSearch
            // 
            this.lblDocDeptSearch.AutoSize = true;
            this.lblDocDeptSearch.Location = new System.Drawing.Point(52, 108);
            this.lblDocDeptSearch.Name = "lblDocDeptSearch";
            this.lblDocDeptSearch.Size = new System.Drawing.Size(97, 13);
            this.lblDocDeptSearch.TabIndex = 2;
            this.lblDocDeptSearch.Text = "Doctor Department";
            // 
            // lblDocSurnameSearch
            // 
            this.lblDocSurnameSearch.AutoSize = true;
            this.lblDocSurnameSearch.Location = new System.Drawing.Point(52, 67);
            this.lblDocSurnameSearch.Name = "lblDocSurnameSearch";
            this.lblDocSurnameSearch.Size = new System.Drawing.Size(84, 13);
            this.lblDocSurnameSearch.TabIndex = 1;
            this.lblDocSurnameSearch.Text = "Doctor Surname";
            // 
            // lblDocIdSearch
            // 
            this.lblDocIdSearch.AutoSize = true;
            this.lblDocIdSearch.Location = new System.Drawing.Point(52, 32);
            this.lblDocIdSearch.Name = "lblDocIdSearch";
            this.lblDocIdSearch.Size = new System.Drawing.Size(53, 13);
            this.lblDocIdSearch.TabIndex = 0;
            this.lblDocIdSearch.Text = "Doctor ID";
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(1024, 104);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 23);
            this.btnLogOut.TabIndex = 1;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            // 
            // lblList
            // 
            this.lblList.AutoSize = true;
            this.lblList.Location = new System.Drawing.Point(480, 217);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(58, 13);
            this.lblList.TabIndex = 2;
            this.lblList.Text = "Doctor List";
            // 
            // DoctorSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 644);
            this.Controls.Add(this.lblList);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.grpSearchDoctor);
            this.Name = "DoctorSearchForm";
            this.Text = "Doctor Search";
            this.grpSearchDoctor.ResumeLayout(false);
            this.grpSearchDoctor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSearchDoctor;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtDocDeptSearch;
        private System.Windows.Forms.TextBox txtDocSurnameSearch;
        private System.Windows.Forms.TextBox txtDocIdSearch;
        private System.Windows.Forms.Label lblDocDeptSearch;
        private System.Windows.Forms.Label lblDocSurnameSearch;
        private System.Windows.Forms.Label lblDocIdSearch;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label lblList;
    }
}