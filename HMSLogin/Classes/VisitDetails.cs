using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMSLogin
{
	class PatientVisitDetails
	{
		public PatientVisitDetails() { }

		public PatientVisitDetails (int visitId, int patientId, int docId,
						int deptId, DateTime admissionDate, DateTime dischargeDate,
						int bedId, DateTime visitTime)
		{
			VisitID = visitId;
			PatientId = patientId;
			DocId = docId;
			DeptId = deptId;
			AdmissionDate = admissionDate;
			DischargeDate = dischargeDate;
			BedId = bedId;
			VisitTime = visitTime;
		}


		public int VisitID { get; set; }
		public int PatientId { get; set; }
		public int DocId { get; set; }
		public int DeptId { get; set; }
		public DateTime AdmissionDate { get; set; }
		public DateTime DischargeDate { get; set; }
		public int BedId { get; set; }
		public DateTime VisitTime { get; set; }


		public override string ToString()
		{
			string newline = Environment.NewLine;

			return $"VisitID: {VisitID} {newline}" +
				$"PatientId: {PatientId} {newline}" +
				$"DocId: {DocId} {newline}" +
				$"DeptId: {DeptId} {newline}" +
				$"AdmissionDate: {AdmissionDate} {newline}" +
				$"DischargeDate: {DischargeDate} {newline}" +
				$"Bed Id: {BedId} {newline}" +
				$"VisitTime: {VisitTime} {newline}";
		}


	}
}
