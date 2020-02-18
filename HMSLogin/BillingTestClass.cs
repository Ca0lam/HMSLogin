using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMSLogin
{
    class BillingTestClass
    {
        public string Name;
        public string Id;
        public DateTime Date;
        public string PatientId;
        public double RoomCharge;
        public double DoctorsFee;
        public string Note;
        public double MiscFee;
        public double TotalFee;

        public override string ToString()
        {
            String billString = "Name: " + Name +
                "\nId: " + Id +
                "\nDate: " + Date.ToString("dd/MM/yy") +
                "\nPatientId: " + PatientId +
                "\nRoomCharge: " + RoomCharge +
                "\nDoctorsFee: " + DoctorsFee +
                "\nNote: " + Note +
                "\nMiscFee: " + MiscFee +
                "\nTotalFee: " + TotalFee;

            return billString;
        }
    }
}
