using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FitnessKlubbUppgiftUml
{
    public class Kund : TrainingClass
    {
        private string Email { get; set; }
        public bool MonthSub { get; set; }
        public bool YearSub { get; set; }

        public string UserName { get; set; }

        public List<TrainingClass> TrainingClass { get; set; } = new List<TrainingClass>();

        public string GetEmail()
        {
            return Email;
        }

        public void SetEmail(string newEmail)
        {
            Email = newEmail;
        }

        public void Run()
        {
            

            if (MonthSub)
                Console.WriteLine($"{UserName} som har månadsabonnemang.");
            else if (YearSub)
                Console.WriteLine($"{UserName} som har årsabonnemang.");
            else
                Console.WriteLine($"{UserName} har inget abonnemang.");
        }
        
    }
}
