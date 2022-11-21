using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEduardoAnacletoWindowsForm1.Models
{
    public class Clients : People
    {
        public Clients()
        {

        }

        public enum TypeOfClient
        {
            Natural = 1,
            Legal = 2
        }

     //   public Addresses deliveryAddress { get; set; }
    }
}
