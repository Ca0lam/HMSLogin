using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMSLogin
{
    public class Doctor
    {
        /* The compiler will generate a private variable for each "automatic" property
* The getter and setters are public though.C:\Users\DSD14\Desktop\PROJECT\Application\HMSLogin\HMSLogin\Doctor.cs
* We will be able to get and set properties e.g.
* Doctor d1 = new Doctor();
* d1.Surname = "McCarthy";
*/
        public int DocId { get; set; }
        public String DocForename { get; set; }
        public String DocSurname { get; set; }
        public byte[] DocPhoto { get; set; }
        public bool DocGender { get; set; }
        public string DocAddress { get; set; }
        public string DocPhoneNumber { get; set; }
        public string DocQualification { get; set; }
        public int DeptId { get; set; }
        public override string ToString()
        {
            string gender;
            if (DocGender)
                gender = "male";
            else
                gender = "female";
            return $"Id: {DocId.ToString()}," +
                $" Doctor Name: {DocForename} {DocSurname}," +
                $" Gender: {DocGender}," +
                $" DocAddress: {DocAddress}," +
                $" DocPhoneNum: {DocPhoneNumber}" +
                $" Qualifications: {DocQualification}" +
                $" Department: {DeptId.ToString()}";
        }
    }
}
