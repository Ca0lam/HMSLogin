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
			formLoad();
		}

		private void createPatientObject()
		{

		}


		private void formLoad()
		{
			int patientID = hospitalMS.tblPatientDetails.FirstOrDefault().PatientId;
			//int patientID = 1006;

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

		private void getPatientByID()
		{

		}


		private void savePatientDetails()
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
			hospitalMS.SubmitChanges();
			Console.WriteLine(JSONresult);

		}

		private void BtnSave_Click(object sender, EventArgs e)
		{
			savePatientDetails();
		}


	}
}
