using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HMSLogin.Classes;
using HMSLogin.Database;
using HMSLogin.Forms;
using Newtonsoft.Json;

namespace HMSLogin
{

	public partial class FrmPatientDetails : Form
	{
	
		
		HospitalMSDataContext hospitalMS;
		public FrmPatientDetails()
		{
			InitializeComponent();
			hospitalMS = new HospitalMSDataContext();
			FormLoad();
		}

		private void CreatePatientObject()
		{

		}


		private void FormLoad()
		{
			ClearPatientNotesComboBox();
			ClearPatientVisitsComboBox();
			int patientID = hospitalMS.tblPatientDetails.FirstOrDefault().PatientId;
			//int patientID = 1006;
			PopulateForm(patientID);
			PopulatePatientNoteComboBox(patientID);
			PopulatePatientNoteList(patientID);

		}


		private void PopulateForm(int patientID)
		{
			BtnSave.Enabled = false;
			BtnUpdate.Enabled = true;
			TxtPatientID.Text = patientID.ToString();
			TxtForename.Text = hospitalMS.tblPatientDetails.Single(x => x.PatientId == patientID).PatientForename;
			TxtSurname.Text = hospitalMS.tblPatientDetails.Single(x => x.PatientId == patientID).PatientSurename;
			TxtDOBDay.Text = hospitalMS.tblPatientDetails.Single(x => x.PatientId == patientID).PatientDOB.Day.ToString("D2");
			TxtDOBMonth.Text = hospitalMS.tblPatientDetails.Single(x => x.PatientId == patientID).PatientDOB.Month.ToString("D2");
			TxtDOBYear.Text = hospitalMS.tblPatientDetails.Single(x => x.PatientId == patientID).PatientDOB.Year.ToString();

			// Only One of these will end up checked
			////bool gender = hospitalMS.tblPatientDetails.Single(x => x.PatientId == patientID).PatientGender;
			////(gender) ? RdoMale.Checked = gender : RdoFemale.Checked;

			RdoMale.Checked = hospitalMS.tblPatientDetails.Single(x => x.PatientId == patientID).PatientGender;
			RdoFemale.Checked = !hospitalMS.tblPatientDetails.Single(x => x.PatientId == patientID).PatientGender;

			TxtPhoneNum.Text = hospitalMS.tblPatientDetails.Single(x => x.PatientId == patientID).PatientPhoneNum.ToString();

			// Address stored as comma seperated values in database, remove the commas and print each line on a new line in the text box
			string address = hospitalMS.tblPatientDetails.Single(x => x.PatientId == patientID).PatientAddress;
			TxtAddress.Text = address.Replace(", ", ",\r\n");

			// NOK Details are stored in JSON format in the Database.
			// They are retrieved here and stored in a string. 
			string nokDetailsJSONString = hospitalMS.tblPatientDetails.Single(x => x.PatientId == patientID).PatientNOK;

			// String is read as JSON here and stored in the nokDetailsConverted variable 
			var nokDetailsConverted = JsonConvert.DeserializeObject<dynamic>(nokDetailsJSONString);
			// New NOK Class is initialized 
			NOK nok = new NOK();
			// JSON values are assigned to NOK Class properties
			nok.NOKName = nokDetailsConverted.NOKName;
			nok.NOKPhoneNum = nokDetailsConverted.NOKPhoneNum;
			// NOK Class properties are assigned to relevant text boxes. 
			TxtNOKName.Text = nok.NOKName;
			TxtNOKPhoneNum.Text = nok.NOKPhoneNum;

			// Extra code to get all Patient IDs in the Database.
			var allIDs = hospitalMS.tblPatientDetails.Select(x => x.PatientSurename).ToList();
			// Loop through all Patient IDs retrieved
			foreach (var row in allIDs)
			{
				Console.WriteLine(row);
			}
		}

		private void PopulatePatientNoteList(int patientID)
		{

		}

		private void GetPatientByID()
		{

		}


		private void SavePatientDetails()
		{

			tblPatientDetail patient = new tblPatientDetail();
			patient.PatientForename = TxtForename.Text;
			patient.PatientSurename = TxtSurname.Text;

			// Format the three text fields for DOB as a string and convert to a DateTime Type
			var patientDOB = Convert.ToDateTime(TxtDOBYear.Text + "-" + TxtDOBMonth.Text + "-" + TxtDOBDay.Text);
			patient.PatientDOB = patientDOB;
			Console.WriteLine(patientDOB);

			if (RdoMale.Checked)
			{
				patient.PatientGender = true;
			}
			else if (RdoFemale.Checked)
			{
				patient.PatientGender = false;
			}
			else
			{
				Console.WriteLine("Gender Error");
			}

			patient.PatientAddress = TxtAddress.Text;
			patient.PatientPhoneNum = TxtPhoneNum.Text;

			NOK nok = new NOK();
			nok.NOKName = TxtNOKName.Text;
			nok.NOKPhoneNum = TxtNOKPhoneNum.Text;
			string JSONresult = JsonConvert.SerializeObject(nok);
			patient.PatientNOK = JSONresult;

			hospitalMS.tblPatientDetails.InsertOnSubmit(patient);
			////hospitalMS.tblPatientDetails.UpdateOnSubmit(patient);
			hospitalMS.SubmitChanges();
			////hospitalMS.tblPatientDetails.SaveChanges();
			Console.WriteLine(JSONresult);

		}

		private void BtnSave_Click(object sender, EventArgs e)
		{
			SavePatientDetails();
		}

		private void BtnSearch_Click(object sender, EventArgs e)
		{
			Search();
		}

		private void TxtSearch_TextChanged(object sender, EventArgs e)
		{
			Search();
		}



		private void LstSearch_SelectedValueChanged(object sender, EventArgs e)
		{
			RefreshFormFromSearch();
		}

		private void Search()
		{
			LstSearch.Items.Clear();
			var searchBox = TxtSearch.Text;
			if (!string.IsNullOrWhiteSpace(searchBox))
			{
				var searchResult = hospitalMS.tblPatientDetails.Where(x => x.PatientSurename.Contains(searchBox) || x.PatientId.ToString().Contains(searchBox)).ToList();
				////var patDet = from tblPatientDetail Select * ;
				Console.WriteLine(searchResult);
				////Console.WriteLine(patDet);
				foreach (var item in searchResult)
				{
					Console.WriteLine(item.PatientForename);
					Console.WriteLine(item.PatientSurename);
					Console.WriteLine(item.PatientDOB);
					LstSearch.Items.Add("Id: " + item.PatientId + " " + "\t" + item.PatientForename + " " + item.PatientSurename + "\n\r");
				}
			}

		}

		private void RefreshFormFromSearch()
		{
			var selectedValue = LstSearch.SelectedItem.ToString();
			Console.WriteLine(selectedValue);
			string[] splitValue = selectedValue.Split(' ');
			Console.WriteLine(splitValue[1].ToString());
			////new[] mystring = selectedValue.Split(' ');
			////String[] Split(selectedValue, " ")
			int selectedPatientID = Int32.Parse(splitValue[1]);
			PopulateForm(selectedPatientID);
			PopulatePatientNoteComboBox(selectedPatientID);
		}


		private void UpdatePatientDetails()
		{
			int patientID = Int32.Parse(TxtPatientID.Text);
			using (HospitalMSDataContext hospitalMS = new HospitalMSDataContext())
			{
				// "id" is the id in your table (parameter passed)
				//Patient patient = hospitalMS.tblPatientDetails.Find(patientID).First();   // Find may be only for Entity Framework. If you can't use it, use the line below
				
				var patient = hospitalMS.tblPatientDetails.Where(x => x.PatientId == patientID).First();

				patient.PatientForename = TxtForename.Text;
				patient.PatientSurename = TxtSurname.Text;
				var patientDOB = Convert.ToDateTime(TxtDOBYear.Text + "-" + TxtDOBMonth.Text + "-" + TxtDOBDay.Text);
				patient.PatientDOB = patientDOB;
				
				if (RdoMale.Checked)
				{
					patient.PatientGender = true;
				}
				else if (RdoFemale.Checked)
				{
					patient.PatientGender = false;
				}
				else
				{
					Console.WriteLine("Gender Error");
				}

				patient.PatientPhoneNum = TxtPhoneNum.Text;
				patient.PatientAddress = TxtAddress.Text;

				NOK nok = new NOK();
				nok.NOKName = TxtNOKName.Text;
				nok.NOKPhoneNum = TxtNOKPhoneNum.Text;
				string JSONresult = JsonConvert.SerializeObject(nok);
				patient.PatientNOK = JSONresult;

				hospitalMS.SubmitChanges();
				FormLoad();
			};
		}


		////private void CreatePatientObject2(int patientID, out Patient patient)
		////{
			////Patient patient = new Patient();
			////patient.PatientForename = TxtForename.Text;
			////patient.PatientSurename = TxtSurname.Text;

			////// Format the three text fields for DOB as a string and convert to a DateTime Type
			////var patientDOB = Convert.ToDateTime(TxtDOBYear.Text + "-" + TxtDOBMonth.Text + "-" + TxtDOBDay.Text);
			////patient.PatientDOB = patientDOB;
			////Console.WriteLine(patientDOB);

			////if (RdoMale.Checked)
			////{
			////	patient.PatientGender = true;
			////}
			////else if (RdoFemale.Checked)
			////{
			////	patient.PatientGender = false;
			////}
			////else
			////{
			////	Console.WriteLine("Gender Error");
			////}

			////patient.PatientAddress = TxtAddress.Text;
			////patient.PatientPhoneNum = TxtPhoneNum.Text;

			////NOK nok = new NOK();
			////nok.NOKName = TxtNOKName.Text;
			////nok.NOKPhoneNum = TxtNOKPhoneNum.Text;
			////string JSONresult = JsonConvert.SerializeObject(nok);
			////patient.PatientNOK = JSONresult;
		////}

		private void BtnUpdate_Click(object sender, EventArgs e)
		{
			UpdatePatientDetails();
		}


		private void PopulatePatientNoteComboBox(int patientId)
		{
			ClearPatientNotesComboBox();
			var listofnotes = hospitalMS.tblPatientNotes.Where(x => x.PatientId.Equals(patientId)).ToList();
			foreach (var item in listofnotes)
			{
				CbxPatientNotes.Items.Add("NoteID#: " + item.PatientNoteId + " Date: " + item.NoteDate.Date.ToShortDateString());
			}
		}

		private void PopulatePatientVisitComboBox(int patientId)
		{
			ClearPatientVisitsComboBox();
			var listofvisits = hospitalMS.tblVisitDetails.Where(x => x.PatientId.Equals(patientId)).ToList();
			foreach (var item in listofvisits)
			{
				CbxPatientNotes.Items.Add("VisitID#: " + item.VisitId + " Date: " + item.PatientId.ToString());
			}
		}


		private void ClearPatientNotesComboBox()
		{
			CbxPatientNotes.Text = null;
			CbxPatientNotes.Items.Clear();
		}

		private void ClearPatientVisitsComboBox()
		{
			CbxVisitDetails.Text = null;
			CbxVisitDetails.Items.Clear();
		}


		private void OpenNote()
		{

		}

		private void NewNote()
		{

		}

		private void btnNewPatientNote_Click(object sender, EventArgs e)
		{
			int patientID = Int32.Parse(TxtPatientID.Text);
			new NewPatientNote(patientID).ShowDialog();
		}

		private void BtnViewNote_Click(object sender, EventArgs e)
		{
			if(CbxPatientNotes.SelectedItem != null)
			{
				////string noteDateString = CbxPatientNotes.SelectedItem.ToString();
				////Console.WriteLine(noteDateString); 
				////var noteDate = Convert.ToDateTime(noteDateString.ToString());

				////var newNote = hospitalMS.tblPatientNotes.Select(x => x.NoteDate.ToString());

				////var newNote = hospitalMS.tblPatientNotes.Single(x => x.NoteDate.Date.Equals(noteDate.Date) && x.NoteDate.TimeOfDay.TotalMinutes.Equals(noteDate.TimeOfDay.TotalMinutes)).PatientNotes;
				////var newNote = hospitalMS.tblPatientNotes.Single(x => DateTime.Compare(x.NoteDate, noteDate) == 0 ? true : false).PatientNotes;
				////var newNote = hospitalMS.tblPatientNotes.Single(x => x.PatientId == 1).PatientNotes;
				////newNote.FirstOrDefault;
				////Console.WriteLine(newNote);

				var patientId = Int32.Parse(TxtPatientID.Text);
				var selectedValue = CbxPatientNotes.SelectedItem.ToString();
				Console.WriteLine(selectedValue);
				string[] splitValue = selectedValue.Split(' ');
				Console.WriteLine(splitValue[1].ToString());
				////new[] mystring = selectedValue.Split(' ');
				////String[] Split(selectedValue, " ")
				int selectedNoteID = Int32.Parse(splitValue[1]);
				var viewNote = hospitalMS.tblPatientNotes.Single(x => x.PatientNoteId == selectedNoteID).PatientNotes;
				Console.WriteLine(viewNote);

				DateTime noteDate = hospitalMS.tblPatientNotes.Single(x => x.PatientNoteId == selectedNoteID).NoteDate;

				new ViewPatientNote(noteDate, patientId, viewNote).ShowDialog();


			}

		}

		private void CbxPatientNotes_Click(object sender, EventArgs e)
		{
			ClearPatientNotesComboBox();
			int patientID = Int32.Parse(TxtPatientID.Text);
			PopulatePatientNoteComboBox(patientID);
		}

		private void CbxVisitDetails_Click(object sender, EventArgs e)
		{
			ClearPatientVisitsComboBox();
			int patientID = Int32.Parse(TxtPatientID.Text);
			PopulatePatientVisitComboBox(patientID);
		}



		private void BtnNew_Click(object sender, EventArgs e)
		{
			CleanForm();
		}


		private void CleanForm()
		{
			TxtPatientID.Text = 0000.ToString();
			TxtForename.Text = null;
			TxtSurname.Text = null;
			TxtDOBDay.Text = null;
			TxtDOBMonth.Text = null;
			TxtDOBYear.Text = null;

			RdoMale.Checked = false;
			RdoFemale.Checked = false;

			TxtPhoneNum.Text = null;
			TxtAddress.Text = null;

			TxtNOKName.Text = null;
			TxtNOKPhoneNum.Text = null;

			TxtSearch.Text = null;
			LstSearch.Text = null;
			CbxPatientNotes.Text = null;

			BtnUpdate.Enabled = false;
			BtnSave.Enabled = true;

		}

		private void BtnCancel_Click(object sender, EventArgs e)
		{
			FormLoad();
		}


	}
}
