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
		public ViewPatientNote(string noteString)
		{
			InitializeComponent();
			PopulateForm(noteString);
		}

		private void PopulateForm(string noteString)
		{
			TxtNoteBody.Text = noteString;
		}


	}
}
