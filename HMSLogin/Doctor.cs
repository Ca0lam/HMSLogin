using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMSLogin
{
    class Doctor
    {
        /* The compiler will generate a private variable for each "automatic" property
* The getter and setters are public though.C:\Users\DSD14\Desktop\PROJECT\Application\HMSLogin\HMSLogin\Doctor.cs
* We will be able to get and set properties e.g.
* Doctor d1 = new Doctor();
* d1.Surname = "McCarthy";
*/
        public int DocID { get; set; }
        public String DocForename { get; set; }
        public String DocSurname { get; set; }
        public byte[] Photo { get; set; }
        public bool Gender { get; set; }
        public string DocAddress { get; set; }
        public string DocPhoneNum { get; set; }
        public string DocQualification { get; set; }
        public int DeptId { get; set; }
        public override string ToString()
        {
            string gender;
            if (Gender)
                gender = "male";
            else
                gender = "female";
            return $"Id: {DocID.ToString()}," +
                $" Doctor Name: {DocForename} {DocSurname}," +
                $" Gender: {gender}," +
                $" DocAddress: {DocAddress}," +
                $" DocPhoneNum: {DocPhoneNum}" +
                $" Qualifications: {DocQualification}" +
                $" Department: {DeptId.ToString()}";
        }
    }
}
