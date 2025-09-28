using System;
using System.Collections.Generic;

namespace FitnessKlubbUppgiftUml
{

    public class TrainingClass //klass 
    {
        public string Name { get; set; }
        public string TypeOfClass { get; set; }
        public Trainer Trainer { get; set; }
        public Schema Schema { get; set; }
        public List<Kund> Deltagare { get; set; } = new List<Kund>(); //lista 


        public void RunTraining()
        {
            Console.WriteLine($"Klass: {Name}, Tränare: {Trainer.TrainerName}, Datum: {Schema.Datum}");
            Console.WriteLine("Deltagare:"); // under här kommer visa alla deltagare
            
        }

    }
}
