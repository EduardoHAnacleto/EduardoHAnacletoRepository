using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEduardoAnacletoWindowsForm1.Models
{
    public class Employees: People
    {
        public Employees()
        {

        }

        public enum JobRole
        {
            Owner = 1,
            Manager = 2,
            Specialist = 3,
            Sales = 4,
            Worker = 5,
            Assistant = 6,
            Cleaning = 7,
            Intern = 8,
            Security = 9
            
        }

        public JobRole jobRole { get; set; }
        public double baseSalary { get; set; }
        public int weeklyHours { get; set; }
        public int levelAccess { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
    }
}
