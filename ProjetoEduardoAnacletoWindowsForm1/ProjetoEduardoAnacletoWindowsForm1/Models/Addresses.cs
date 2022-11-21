using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEduardoAnacletoWindowsForm1.Models
{
    public class Addresses : Identifications
    {
        public Addresses()
        {

        }

        public enum HomeType
        {
            House = 1,
            Appartment = 2
        }

        public string streetName { get; set; }
        public string district { get; set; }
        public string houseNumber { get; set; }
        public HomeType homeType { get; set; }
        public string complement { get; set; }
        public string zipCode { get; set; }
        public Cities city { get; set; }
    }
}
