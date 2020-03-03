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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.docIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docForenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docPhotoDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.docGenderDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocPhoneNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docQualificationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocDeptId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doctorsDataSet = new HMSLogin.DoctorsDataSet();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.doctorTableAdapter = new HMSLogin.DoctorsDataSetTableAdapters.DoctorTableAdapter();
            this.grpSearchDoctor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsDataSet)).BeginInit();
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
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // txtDocDeptSearch
            // 
            this.txtDocDeptSearch.Location = new System.Drawing.Point(308, 108);
            this.txtDocDeptSearch.Name = "txtDocDeptSearch";
            this.txtDocDeptSearch.Size = new System.Drawing.Size(167, 20);
            this.txtDocDeptSearch.TabIndex = 5;
            this.txtDocDeptSearch.TextChanged += new System.EventHandler(this.TxtDocDeptSearch_Leave);
            this.txtDocDeptSearch.Leave += new System.EventHandler(this.TxtDocDeptSearch_Leave);
            // 
            // txtDocSurnameSearch
            // 
            this.txtDocSurnameSearch.Location = new System.Drawing.Point(308, 67);
            this.txtDocSurnameSearch.Name = "txtDocSurnameSearch";
            this.txtDocSurnameSearch.Size = new System.Drawing.Size(167, 20);
            this.txtDocSurnameSearch.TabIndex = 4;
            this.txtDocSurnameSearch.TextChanged += new System.EventHandler(this.TxtDocSurnameSearch_Leave);
            this.txtDocSurnameSearch.Leave += new System.EventHandler(this.TxtDocSurnameSearch_Leave);
            // 
            // txtDocIdSearch
            // 
            this.txtDocIdSearch.Location = new System.Drawing.Point(308, 32);
            this.txtDocIdSearch.Name = "txtDocIdSearch";
            this.txtDocIdSearch.Size = new System.Drawing.Size(167, 20);
            this.txtDocIdSearch.TabIndex = 3;
            this.txtDocIdSearch.TextChanged += new System.EventHandler(this.TxtDocIdSearch_Leave);
            this.txtDocIdSearch.Leave += new System.EventHandler(this.TxtDocIdSearch_Leave);
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
            this.btnLogOut.Location = new System.Drawing.Point(1046, 41);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 23);
            this.btnLogOut.TabIndex = 1;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.BtnLogOut_Click);
            // 
            // lblList
            // 
            this.lblList.AutoSize = true;
            this.lblList.Location = new System.Drawing.Point(504, 204);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(58, 13);
            this.lblList.TabIndex = 2;
            this.lblList.Text = "Doctor List";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.docIdDataGridViewTextBoxColumn,
            this.docForenameDataGridViewTextBoxColumn,
            this.docSurnameDataGridViewTextBoxColumn,
            this.docPhotoDataGridViewImageColumn,
            this.docGenderDataGridViewCheckBoxColumn,
            this.docAddressDataGridViewTextBoxColumn,
            this.DocPhoneNum,
            this.docQualificationDataGridViewTextBoxColumn,
            this.DocDeptId});
            this.dataGridView1.DataSource = this.doctorBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(87, 233);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(946, 399);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // docIdDataGridViewTextBoxColumn
            // 
            this.docIdDataGridViewTextBoxColumn.DataPropertyName = "DocId";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.docIdDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.docIdDataGridViewTextBoxColumn.HeaderText = "DocId";
            this.docIdDataGridViewTextBoxColumn.Name = "docIdDataGridViewTextBoxColumn";
            this.docIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // docForenameDataGridViewTextBoxColumn
            // 
            this.docForenameDataGridViewTextBoxColumn.DataPropertyName = "DocForename";
            this.docForenameDataGridViewTextBoxColumn.HeaderText = "DocForename";
            this.docForenameDataGridViewTextBoxColumn.Name = "docForenameDataGridViewTextBoxColumn";
            this.docForenameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // docSurnameDataGridViewTextBoxColumn
            // 
            this.docSurnameDataGridViewTextBoxColumn.DataPropertyName = "DocSurname";
            this.docSurnameDataGridViewTextBoxColumn.HeaderText = "DocSurname";
            this.docSurnameDataGridViewTextBoxColumn.Name = "docSurnameDataGridViewTextBoxColumn";
            this.docSurnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // docPhotoDataGridViewImageColumn
            // 
            this.docPhotoDataGridViewImageColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.docPhotoDataGridViewImageColumn.DataPropertyName = "DocPhoto";
            this.docPhotoDataGridViewImageColumn.HeaderText = "DocPhoto";
            this.docPhotoDataGridViewImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.docPhotoDataGridViewImageColumn.Name = "docPhotoDataGridViewImageColumn";
            this.docPhotoDataGridViewImageColumn.ReadOnly = true;
            this.docPhotoDataGridViewImageColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.docPhotoDataGridViewImageColumn.Width = 61;
            // 
            // docGenderDataGridViewCheckBoxColumn
            // 
            this.docGenderDataGridViewCheckBoxColumn.DataPropertyName = "DocGender";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.docGenderDataGridViewCheckBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.docGenderDataGridViewCheckBoxColumn.HeaderText = "DocGender";
            this.docGenderDataGridViewCheckBoxColumn.Name = "docGenderDataGridViewCheckBoxColumn";
            this.docGenderDataGridViewCheckBoxColumn.ReadOnly = true;
            this.docGenderDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.docGenderDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // docAddressDataGridViewTextBoxColumn
            // 
            this.docAddressDataGridViewTextBoxColumn.DataPropertyName = "DocAddress";
            this.docAddressDataGridViewTextBoxColumn.HeaderText = "DocAddress";
            this.docAddressDataGridViewTextBoxColumn.Name = "docAddressDataGridViewTextBoxColumn";
            this.docAddressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // DocPhoneNum
            // 
            this.DocPhoneNum.DataPropertyName = "DocPhoneNumber";
            this.DocPhoneNum.HeaderText = "DocPhoneNumber";
            this.DocPhoneNum.Name = "DocPhoneNum";
            this.DocPhoneNum.ReadOnly = true;
            // 
            // docQualificationDataGridViewTextBoxColumn
            // 
            this.docQualificationDataGridViewTextBoxColumn.DataPropertyName = "DocQualification";
            this.docQualificationDataGridViewTextBoxColumn.HeaderText = "DocQualification";
            this.docQualificationDataGridViewTextBoxColumn.Name = "docQualificationDataGridViewTextBoxColumn";
            this.docQualificationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // DocDeptId
            // 
            this.DocDeptId.DataPropertyName = "DeptId";
            this.DocDeptId.HeaderText = "DeptId";
            this.DocDeptId.Name = "DocDeptId";
            this.DocDeptId.ReadOnly = true;
            // 
            // doctorBindingSource
            // 
            this.doctorBindingSource.DataMember = "Doctor";
            this.doctorBindingSource.DataSource = this.doctorsDataSet;
            this.doctorBindingSource.CurrentChanged += new System.EventHandler(this.doctorBindingSource_CurrentChanged);
            // 
            // doctorsDataSet
            // 
            this.doctorsDataSet.DataSetName = "DoctorsDataSet";
            this.doctorsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(1046, 104);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 23);
            this.btnAddNew.TabIndex = 4;
            this.btnAddNew.Text = "Add Doctor";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(1065, 269);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 40);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "View or Edit Doctor";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // doctorTableAdapter
            // 
            this.doctorTableAdapter.ClearBeforeFill = true;
            // 
            // DoctorSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 644);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblList);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.grpSearchDoctor);
            this.Name = "DoctorSearchForm";
            this.Text = "Doctor Search";
            this.Load += new System.EventHandler(this.DoctorSearchForm_Load);
            this.grpSearchDoctor.ResumeLayout(false);
            this.grpSearchDoctor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsDataSet)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private DoctorsDataSet doctorsDataSet;
        private System.Windows.Forms.BindingSource doctorBindingSource;
        private DoctorsDataSetTableAdapters.DoctorTableAdapter doctorTableAdapter;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn docPhoneNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn docDeptIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn docIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn docForenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn docSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn docPhotoDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn docGenderDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn docAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocPhoneNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn docQualificationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocDeptId;
    }
}