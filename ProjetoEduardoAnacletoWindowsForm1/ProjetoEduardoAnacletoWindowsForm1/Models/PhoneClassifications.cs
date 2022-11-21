using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEduardoAnacletoWindowsForm1.Models
{
    public class PhoneClassifications : Identifications
    {
        public enum PhoneClass
        {
            PersonalPhone = 1,
            WorkPhone = 2,
            HousePhone = 3,
            ParentsPhone = 4,
            RelativesPhone = 5,
            FriendlyPhone = 6,
            NoPhone = 7
        }
    }
}
