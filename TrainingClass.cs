using System;
using System.Collections.Generic;

namespace FitnessKlubbUppgiftUml
{
    public class Kund
    {
        public string UserName { get; set; }
    }

    public class TrainingClass //klass 
    {
        public string Name { get; set; }
        public string TypeOfClass { get; set; }
        public Trainer Trainer { get; set; }
        public Schema Schema { get; set; }
        public List<Kund> Deltagare { get; set; } = new List<Kund>(); //lista 

        public void ShowUser() //metod för att visa det hela 
        {
            Console.WriteLine($"Klass: {Name}, Tränare: {Trainer.TrainerName}, Datum: {Schema.Datum}");
            Console.WriteLine("Deltagare:"); // under här kommer visa alla deltagare
            foreach (var deltagare in Deltagare) //foreach visar varhje deltagare som ska var med 
            {
                Console.WriteLine(deltagare.UserName);
            }
        }
    }
}
