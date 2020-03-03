using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using HMSLogin.Database;

namespace HMSLogin
{
    public partial class HMSBilling : Form
    {
        HospitalMSDataContext HMSData;
        DateTime date;
        readonly CultureInfo culture = CultureInfo.CreateSpecificCulture("en-ie");
        readonly NumberStyles number = NumberStyles.Number | NumberStyles.AllowCurrencySymbol;
        int bill = 0;
        BillingTestClass printTest = new BillingTestClass();

        public HMSBilling(/*int visitId*/)
        {
            InitializeComponent();
            HMSData = new HospitalMSDataContext();
            var billTable = HMSData.tblBillingDetails;
            var patientTable = HMSData.tblPatientDetails;

            TxtName.Text =
                patientTable.Select(x => x.PatientForename).First()
                + " " + patientTable.Select(x => x.PatientSurename).First();
            //TxtName.Text = patientTable.Select(x => x.PatientForename).Where(x => x.visitId == 999999).First();

            int billingId = billTable.Select(x => x.VisitId).First();
            TxtId.Text = billingId.ToString();
            bill = billingId;

            date = billTable.Select(x => x.BillingDate).First();
            //DateTime date = billTable.Select(x => x.BillingDate).Where(x => x.visitId == 1234).First();
            MthCalendar.SetSelectionRange(date, date);

            TxtPatientId.Text =
                billTable.Select(x => x.PatientId).First().ToString();
            //TxtPatientId.Text = billTable.Select(x => x.PatientId).Where(x => x.visitId == 999999).First();

            decimal roomCharge = billTable.Select(x => x.RoomCharge).First();
            TxtRoomCharge.Text = roomCharge.ToString("C", culture);

            decimal doctorsFee = billTable.Select(x => x.DoctorsFee).First();
            TxtDoctorsFee.Text = doctorsFee.ToString("C", culture);

            TxtNote.Text =
                billTable.Select(x => x.BillingNote).FirstOrDefault();

            decimal miscFee = billTable.Select(x => x.MiscBillingFee).First();
            TxtMiscFee.Text = miscFee.ToString("C", culture);

            decimal totFee = roomCharge + doctorsFee + miscFee;
            TxtTotalFee.Text = totFee.ToString("C", culture);


            MthCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.MthCalendar_DateSelected);
        }

        private void MthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            date = e.Start;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {

            printTest.Name = TxtName.Text;
            printTest.Id = TxtId.Text;
            printTest.Date = date;
            printTest.PatientId = TxtPatientId.Text;

            if (double.TryParse(TxtDoctorsFee.Text, out double docFee))
            {
                printTest.DoctorsFee = docFee;
            }
            else
            {
                Console.WriteLine("Error: Doctors Fee is not double");
            };

            if (double.TryParse(TxtMiscFee.Text, out double miscFee))
            {
                printTest.MiscFee = miscFee;
            }
            else
            {
                Console.WriteLine("Error: Misc Fee is not double");
            };

            if (double.TryParse(TxtTotalFee.Text, out double totFee))
            {
                printTest.TotalFee = totFee;
            }
            else
            {
                Console.WriteLine("Error: Total Fee is not double");
            };

            Console.WriteLine(printTest);

            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private System.Drawing.Printing.PrintDocument docToPrint =
    new System.Drawing.Printing.PrintDocument();

        private void printDocument1_PrintPage_1(object sender, PrintPageEventArgs e)
        {
            Font fntHeading = new Font(FontFamily.GenericMonospace, 18, FontStyle.Bold ^ FontStyle.Italic);
            Font fntSmallHeading = new Font(FontFamily.GenericMonospace, 12, FontStyle.Italic);
            Font fntBody = new Font(FontFamily.GenericMonospace, 8);
            Font fntPrice = new Font(FontFamily.GenericMonospace, 8, FontStyle.Bold);

            //Title
            e.Graphics.DrawString("Bill: " + bill.ToString("D6"), fntHeading, Brushes.Black, 10, 10);
            e.Graphics.DrawString(DateTime.Now.ToShortDateString(), fntSmallHeading, Brushes.Black, 40, 41);

            int line = 62;
            int lineIncr = 12;
            int col1 = 10;
            int col2 = 100;

            //Column 1
            e.Graphics.DrawString("Name: ", fntBody, Brushes.Black, col1, line);
            line += lineIncr;
            e.Graphics.DrawString("Id: ", fntBody, Brushes.Black, col1, line);
            line += lineIncr;
            e.Graphics.DrawString("Date: ", fntBody, Brushes.Black, col1, line);
            line += lineIncr;
            e.Graphics.DrawString("PatientId: ", fntBody, Brushes.Black, col1, line);
            line += lineIncr;
            e.Graphics.DrawString("RoomCharge: ", fntBody, Brushes.Black, col1, line);
            line += lineIncr;
            e.Graphics.DrawString("DoctorsFee: ", fntBody, Brushes.Black, col1, line);
            line += lineIncr;
            e.Graphics.DrawString("Note: ", fntBody, Brushes.Black, col1, line);
            line += lineIncr*4;
            e.Graphics.DrawString("MiscFee: ", fntBody, Brushes.Black, col1, line);
            line += lineIncr*2;
            e.Graphics.DrawString("TotalFee: ", fntPrice, Brushes.Black, col1, line);



            //Column 2
            line = 62;
            e.Graphics.DrawString(TxtName.Text, fntBody, Brushes.Black, col2, line);
            line += lineIncr;
            e.Graphics.DrawString(TxtId.Text, fntBody, Brushes.Black, col2, line);
            line += lineIncr;
            e.Graphics.DrawString(date.ToString("yy-MM-dd"), fntBody, Brushes.Black, col2, line);
            line += lineIncr;
            e.Graphics.DrawString(TxtPatientId.Text, fntBody, Brushes.Black, col2, line);
            line += lineIncr;
            e.Graphics.DrawString(TxtRoomCharge.Text, fntBody, Brushes.Black, col2, line);
            line += lineIncr;
            e.Graphics.DrawString(TxtDoctorsFee.Text, fntBody, Brushes.Black, col2, line);
            line += lineIncr;

            string noteText = TxtNote.Text;
            int noteLength = noteText.Length;
            Console.WriteLine(noteLength);

            if (noteLength < 15)
            {
                e.Graphics.DrawString(TxtNote.Text, fntBody, Brushes.Black, col2, line);
            }
            else if(noteText.Length < 30)
            {
                e.Graphics.DrawString(TxtNote.Text.Substring(0, 15), fntBody, Brushes.Black, col2, line);
                line += lineIncr - 3;
                e.Graphics.DrawString(TxtNote.Text.Substring(15, noteLength-15), fntBody, Brushes.Black, col2, line);
            }
            else if (noteText.Length < 45)
            {
                e.Graphics.DrawString(TxtNote.Text.Substring(0, 15), fntBody, Brushes.Black, col2, line);
                line += lineIncr - 3;
                e.Graphics.DrawString(TxtNote.Text.Substring(15, 15), fntBody, Brushes.Black, col2, line);
                line += lineIncr - 3;
                e.Graphics.DrawString(TxtNote.Text.Substring(30, noteLength-30), fntBody, Brushes.Black, col2, line);
            }
            else if (noteText.Length < 60)
            {
                e.Graphics.DrawString(TxtNote.Text.Substring(0, 15), fntBody, Brushes.Black, col2, line);
                line += lineIncr - 3;
                e.Graphics.DrawString(TxtNote.Text.Substring(15, 15), fntBody, Brushes.Black, col2, line);
                line += lineIncr - 3;
                e.Graphics.DrawString(TxtNote.Text.Substring(30, 15), fntBody, Brushes.Black, col2, line);
                line += lineIncr - 3;
                e.Graphics.DrawString(TxtNote.Text.Substring(45, noteLength - 45), fntBody, Brushes.Black, col2, line);
            }
            else
            {
                e.Graphics.DrawString(TxtNote.Text.Substring(0, 15), fntBody, Brushes.Black, col2, line);
                line += lineIncr - 3;
                e.Graphics.DrawString(TxtNote.Text.Substring(15, 15), fntBody, Brushes.Black, col2, line);
                line += lineIncr -3;
                e.Graphics.DrawString(TxtNote.Text.Substring(30, 15), fntBody, Brushes.Black, col2, line);
                line += lineIncr - 3;
                e.Graphics.DrawString(TxtNote.Text.Substring(45, 15), fntBody, Brushes.Black, col2, line);
                line += lineIncr - 3;
                e.Graphics.DrawString(TxtNote.Text.Substring(60, 15), fntBody, Brushes.Black, col2, line);
            }

            line = 182;
            e.Graphics.DrawString(TxtMiscFee.Text, fntBody, Brushes.Black, col2, line);
            line += lineIncr*2;
            e.Graphics.DrawString(TxtTotalFee.Text, fntPrice, Brushes.Black, col2, line);



            //Lines
            Pen blackPen = new Pen(Color.Black, 1);

            Point line1 = new Point(0, 41);
            Point line2 = new Point(210, 41);
            e.Graphics.DrawLine(blackPen, line1, line2);

            line1 = new Point(0, 60);
            line2 = new Point(210, 60);
            e.Graphics.DrawLine(blackPen, line1, line2);

            line1 = new Point(0, 200);
            line2 = new Point(210, 200);
            e.Graphics.DrawLine(blackPen, line1, line2);

            line1 = new Point(90, 60);
            line2 = new Point(90, 240);
            e.Graphics.DrawLine(blackPen, line1, line2);
        }
    }
}
