using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMSLogin
{
	class PatientNote
	{


		public PatientNote() { }

		public PatientNote(int noteId, int patientId,
						DateTime date, string note)
		{
			NoteId = noteId;
			PatientId = patientId;
			Date = date;
			Note = note;
		}


		public int NoteId { get; set; }
		public int PatientId { get; set; }
		public DateTime Date { get; set; }
		public string Note { get; set; }



		public override string ToString()
		{
			string newline = Environment.NewLine;

			return $"NoteId: {NoteId} {newline}" +
				$"PatientId: {PatientId} {newline}" +
				$"Date: {Date} {newline}" +
				$"Note: {Note} {newline}";
		}

	}
}
