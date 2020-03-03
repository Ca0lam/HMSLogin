using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMSLogin.Forms
{
	public partial class ViewPatientNote : Form
	{
		public ViewPatientNote(DateTime noteDate, int patientId, string noteString)
		{
			InitializeComponent();
			PopulateForm(noteDate, patientId, noteString); 
		}

		private void PopulateForm(DateTime noteDate, int patientId, string noteString)
		{
			this.ActiveControl = null;
			TxtNoteBody.Text = noteString;
			LblDate.Text = noteDate.ToShortDateString();
			LblPatientId.Text = patientId.ToString();
		}

		private void BtnClose_Click(object sender, EventArgs e)
		{
			this.Dispose();
		}
	}
}
