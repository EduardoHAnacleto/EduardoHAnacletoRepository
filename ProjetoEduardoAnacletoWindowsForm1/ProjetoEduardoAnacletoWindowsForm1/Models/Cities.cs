using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEduardoAnacletoWindowsForm1.Models
{
    public class Cities : Identifications
    {
        public Cities()
        {

        }

        public string cityName { get; set; }
        public string phonePrefix { get; set; }
        public States state { get; set; }
    }
}
