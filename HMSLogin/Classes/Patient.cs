using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMSLogin
{
	class Patient
	{

		public Patient() { }

		public Patient( int patientId, string patientForename, string patientSurname, 
						DateTime patientDOB, bool patientGender, string patientAddress,
						string patientPhoneNum, string patientNOK)
		{
			PatientID = patientId;
			PatientForename = patientForename;
			PatientSurname = patientSurname;
			PatientDOB = patientDOB;
			PatientGender = patientGender;
			PatientAddress = patientAddress;
			PatientPhoneNum = patientPhoneNum;
			PatientNOK = patientNOK;
		}


		public int PatientID { get; set; }
		public string PatientForename { get; set; }
		public string PatientSurname { get; set; }
		public DateTime PatientDOB { get; set; }
		public bool PatientGender { get; set; }
		public string PatientAddress { get; set; }
		public string PatientPhoneNum { get; set; }
		public string PatientNOK { get; set; }


		public override string ToString()
		{
			string newline = Environment.NewLine;

			return $"PatientID: {PatientID} {newline}" +
				$"Forename: {PatientForename} {newline}" +
				$"Surname: {PatientSurname} {newline}" +
				$"DOB: {PatientDOB} {newline}" +
				$"Gender: {PatientGender} {newline}" +
				$"Address: {PatientAddress} {newline}" +
				$"PhoneNum: {PatientPhoneNum} {newline}" +
				$"NOK: {PatientNOK} {newline}";
		}

	}
}
