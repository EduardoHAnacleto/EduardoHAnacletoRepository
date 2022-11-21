using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEduardoAnacletoWindowsForm1.Models
{
    public class People : Identifications
    {
        public People()
        {

        }

        public string firstName { get; set; }
        public string middleName { get; set; }
        public string lastName { get; set; }
        public int gender { get; set; }
        public int age { get; set; }
        protected string registrationNumber { get; set; }
        public DateTime dateOfBirth { get; set; }
        public Addresses address { get; set; }
        public string email { get; set; }

        public string phoneNumber1 { get; set; }
        public string phoneNumber2 { get; set; }
        public string phoneNumber3 { get; set; }
        public PhoneClassifications phoneClass1 { get; set; }
        public PhoneClassifications phoneClass2 { get; set; }
        public PhoneClassifications phoneClass3 { get; set; }
    }
}
