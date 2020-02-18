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

namespace HMSLogin
{
    public partial class HMSBilling : Form
    {
        DateTime date;
        readonly CultureInfo culture = CultureInfo.CreateSpecificCulture("en-ie");
        readonly NumberStyles number = NumberStyles.Number | NumberStyles.AllowCurrencySymbol;
        int bill = 0;
        BillingTestClass printTest = new BillingTestClass();
        public HMSBilling()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            printTest.Name = TxtName.Text;
            printTest.Id = TxtId.Text;


            String testDate = TxtDateDay.Text + "/" + TxtDateMonth.Text + "/" + TxtDateYear.Text;
            if (DateTime.TryParse(testDate, out date))
            {
                printTest.Date = date;
            }
            else
            {
                Console.WriteLine("Error: Date Format");
            };

            printTest.PatientId = TxtPatientId.Text;

            double docFee;
            if (double.TryParse(TxtDoctorsFee.Text, out docFee))
            {
                printTest.DoctorsFee = docFee;
            }
            else
            {
                Console.WriteLine("Error: Doctors Fee is not double");
            };

            double miscFee;
            if (double.TryParse(TxtMiscFee.Text, out miscFee))
            {
                printTest.MiscFee = miscFee;
            }
            else
            {
                Console.WriteLine("Error: Misc Fee is not double");
            };

            double totFee;
            if (double.TryParse(TxtTotalFee.Text, out totFee))
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

            e.Graphics.DrawString("Bill: " + bill.ToString("D6"), fntHeading, Brushes.Black, 10, 10);
            e.Graphics.DrawString(DateTime.Now.ToShortDateString(), fntSmallHeading, Brushes.Black, 40, 40);

            int line = 60;
            int lineIncr = 12;
            int col1 = 10;
            int col2 = 100;

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

            line = 60;

            e.Graphics.DrawString(TxtName.Text, fntBody, Brushes.Black, col2, line);
            line += lineIncr;
            e.Graphics.DrawString(TxtId.Text, fntBody, Brushes.Black, col2, line);
            line += lineIncr;
            e.Graphics.DrawString(date.ToString("dd/MM/yy"), fntBody, Brushes.Black, col2, line);
            line += lineIncr;
            e.Graphics.DrawString(TxtPatientId.Text, fntBody, Brushes.Black, col2, line);
            line += lineIncr;
            e.Graphics.DrawString("€"+TxtRoomCharge.Text, fntBody, Brushes.Black, col2, line);
            line += lineIncr;
            e.Graphics.DrawString("€" + TxtDoctorsFee.Text, fntBody, Brushes.Black, col2, line);
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

            line = 180;
            e.Graphics.DrawString("€" + TxtMiscFee.Text, fntBody, Brushes.Black, col2, line);
            line += lineIncr*2;
            e.Graphics.DrawString("€" + TxtTotalFee.Text, fntPrice, Brushes.Black, col2, line);

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
