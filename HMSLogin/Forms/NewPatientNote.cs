using HMSLogin.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMSLogin
{
	public partial class NewPatientNote : Form
	{

		HospitalMSDataContext hospitalMS;

		public NewPatientNote(int patientId)
		{
			InitializeComponent();
			hospitalMS = new HospitalMSDataContext();
			PopulateForm(patientId);
		}


		private void PopulateForm(int patientId)
		{
			LblDate.Text = DateTime.Now.ToString();
			LblPatientId.Text = patientId.ToString();

		}


		private void SaveNote()
		{
			tblPatientNote patientNote = new tblPatientNote();
			patientNote.PatientId = Int32.Parse(LblPatientId.Text);
			patientNote.NoteDate = DateTime.Now;
			patientNote.PatientNotes = TxtNoteBody.Text;
			
			hospitalMS.tblPatientNotes.InsertOnSubmit(patientNote);
			hospitalMS.SubmitChanges();
		}

		private void BtnSave_Click(object sender, EventArgs e)
		{
			SaveNote();
			this.Dispose();
			////Form.Close();
			///

		}

	}
}
