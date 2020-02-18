using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
		public class NOK
		{
			public string NOKName { get; set; }
			public string NOKPhoneNum { get; set; }
		}


		private void formLoad()
		{
			int patientID = hospitalMS.tblPatientDetails.FirstOrDefault().PatientId;
			//int patientID = 2;

			TxtPatientID.Text = patientID.ToString();
			TxtForename.Text = hospitalMS.tblPatientDetails.Single(x => x.PatientId == patientID).PatientForename;
			TxtSurname.Text = hospitalMS.tblPatientDetails.Single(x => x.PatientId == patientID).PatientSurename;
			TxtDOBDay.Text = hospitalMS.tblPatientDetails.Single(x => x.PatientId == patientID).PatientDOB.Day.ToString("D2");
			TxtDOBMonth.Text = hospitalMS.tblPatientDetails.Single(x => x.PatientId == patientID).PatientDOB.Month.ToString("D2");
			TxtDOBYear.Text = hospitalMS.tblPatientDetails.Single(x => x.PatientId == patientID).PatientDOB.Year.ToString();
			//TxtSurname.Text = hospitalMS.tblPatientDetails.Single(x => x.PatientId == patientID).PatientSurename;

			RdoMale.Checked = hospitalMS.tblPatientDetails.Single(x => x.PatientId == patientID).PatientGender;
			RdoFemale.Checked = !hospitalMS.tblPatientDetails.Single(x => x.PatientId == patientID).PatientGender;

			//var gender = hospitalMS.tblPatientDetails.Single(x => x.PatientId == patientID).PatientGender;
			//(gender) ? CheckBox(RdoMale) : 

			string address = hospitalMS.tblPatientDetails.Single(x => x.PatientId == patientID).PatientAddress;
			TxtAddress.Text = address.Replace(", ", ",\r\n");

			string nokDetails = hospitalMS.tblPatientDetails.Single(x => x.PatientId == patientID).PatientNOK;

			var nokDetailsConverted = JsonConvert.DeserializeObject<dynamic>(nokDetails);
			//string nokName = nokDetailsConverted.NOK.NOKName;
			//string nokPhoneNum = nokDetailsConverted.NOK.NOKPhoneNum;
			NOK nok = new NOK();
			nok.NOKName = nokDetailsConverted.NOKName;
			nok.NOKPhoneNum = nokDetailsConverted.NOKPhoneNum;

			Console.WriteLine(nok.NOKName + nok.NOKPhoneNum);
			//Console.WriteLine(nokName + " " + nokPhoneNum);


			//var allIDs = hospitalMS.tblPatientDetails;
			var allIDs = hospitalMS.tblPatientDetails.Select(x => x.PatientSurename).ToList();

			

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
			//using (HospitalMSDataContext objHospitalMSDataContext = new HospitalMSDataContext())
			//{
			//}

			tblPatientDetail patient = new tblPatientDetail();
			patient.PatientForename = TxtForename.Text;
			patient.PatientSurename = TxtSurname.Text;
			patient.PatientDOB = DateTime.Now;
			patient.PatientGender = true;
			patient.PatientAddress = "Testing Address";
			patient.PatientPhoneNum = TxtPhoneNum.Text;
			//patient.PatientNOK = "Cally Shields, 0874536573";
			//patient.PatientNOK = "{ "NOK":{ "NOKName":"Amanda Bone","NOKPhoneNum":"0871234567"} }";


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
