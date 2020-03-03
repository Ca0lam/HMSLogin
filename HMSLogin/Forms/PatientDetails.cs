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
			ClearComboBox();
			int patientID = hospitalMS.tblPatientDetails.FirstOrDefault().PatientId;
			//int patientID = 1006;
			PopulateForm(patientID);
			PopulateComboBox(patientID);
		}


		private void PopulateForm(int patientID)
		{
			TxtPatientID.Text = patientID.ToString();
			TxtForename.Text = hospitalMS.tblPatientDetails.Single(x => x.PatientId == patientID).PatientForename;
			TxtSurname.Text = hospitalMS.tblPatientDetails.Single(x => x.PatientId == patientID).PatientSurename;
			TxtDOBDay.Text = hospitalMS.tblPatientDetails.Single(x => x.PatientId == patientID).PatientDOB.Day.ToString("D2");
			TxtDOBMonth.Text = hospitalMS.tblPatientDetails.Single(x => x.PatientId == patientID).PatientDOB.Month.ToString("D2");
			TxtDOBYear.Text = hospitalMS.tblPatientDetails.Single(x => x.PatientId == patientID).PatientDOB.Year.ToString();

			// Only One of these will end up checked
			RdoMale.Checked = hospitalMS.tblPatientDetails.Single(x => x.PatientId == patientID).PatientGender;
			RdoFemale.Checked = !hospitalMS.tblPatientDetails.Single(x => x.PatientId == patientID).PatientGender;

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
					LstSearch.Items.Add(item.PatientId + " " + item.PatientForename + " " + item.PatientSurename + "\n\r");
				}
			}

		}

		private void RefreshFormFromSearch()
		{
			var selectedValue = LstSearch.SelectedItem.ToString();
			Console.WriteLine(selectedValue);
			string[] splitValue = selectedValue.Split(' ');
			Console.WriteLine(splitValue[0].ToString());
			////new[] mystring = selectedValue.Split(' ');
			////String[] Split(selectedValue, " ")
			int selectedPatientID = Int32.Parse(splitValue[0]);
			PopulateForm(selectedPatientID);
			PopulateComboBox(selectedPatientID);
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

				patient.PatientAddress = TxtAddress.Text;
				patient.PatientPhoneNum = TxtPhoneNum.Text;

				NOK nok = new NOK();
				nok.NOKName = TxtNOKName.Text;
				nok.NOKPhoneNum = TxtNOKPhoneNum.Text;
				string JSONresult = JsonConvert.SerializeObject(nok);
				patient.PatientNOK = JSONresult;

				hospitalMS.SubmitChanges();
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


		private void PopulateComboBox(int patientId)
		{

			var listofnotes = hospitalMS.tblPatientNotes.Where(x => x.PatientId.Equals(patientId)).ToList();
			foreach (var item in listofnotes)
			{
				CbxPatientNotes.Items.Add(item.NoteDate.ToString());
			}
		

			////CbxPatientNotes.Items.Add("One");
			////CbxPatientNotes.Items.Add("Two");
			////CbxPatientNotes.Items.Add("Three");
			////CbxPatientNotes.Items.Add("Four");
			////CbxPatientNotes.Items.Add("Five");
			////CbxPatientNotes.Items.Add("Six");
			////CbxPatientNotes.Items.Add("Seven");

		}

		private void ClearComboBox()
		{
			CbxPatientNotes.Items.Clear();
		}


		private void OpenNote()
		{

		}

		private void NewNote()
		{

		}

		private void btnNewPatientNote_Click(object sender, EventArgs e)
		{
			new PatientNotes(5).ShowDialog();
		}

		private void BtnViewNote_Click(object sender, EventArgs e)
		{

		}
	}
}
