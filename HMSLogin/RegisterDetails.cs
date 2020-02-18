using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMSLogin
{
    class RegisterDetails
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public DateTime DOB { get; set; }
        public string MobileNo { get; set; }
        public string PersonName { get; set; }
        public string PhoneNo { get; set; }
        public string Relationship { get; set; }

        public override string ToString()
        {
            string newline = Environment.NewLine;
            return $"Id: {Id} {newline}" +
                $"FirstName: {FirstName} {newline}" +
                $"SurName: {SurName} {newline}" +
                $"Gender: {Gender} {newline}" +
                $"Address: {Address} {newline}" +
                $"DOB: {DOB} {newline}" +
                $"Mobile No: {MobileNo} {newline}" +
                $"Person Name: {PersonName} {newline}" +
                $"Phone No: {PhoneNo} {newline}" +
                $"Relationship: {Relationship}";
        }

    }
}
