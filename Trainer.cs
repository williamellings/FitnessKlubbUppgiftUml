using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessKlubbUppgiftUml
{
    public class Trainer
    {
        public string TrainerName { get; set; }
        public string TypeOfTrainer { get; set; }

        public Schema Schema { get; set; }

        public void AddNewUser()
        {
            Console.WriteLine($"{TrainerName} ({TypeOfTrainer}) har fått ett nytt schema: {Schema.Datum}");
        }

    }
}
