namespace FitnessKlubbUppgiftUml
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, välkommen till gymmet!");

            // Skapa objekt
            Trainer Jacob = new Trainer { TrainerName = "Jacob", TypeOfTrainer = "Yoga" }; //den nya tränare och vad han ska träna i 
            Schema yogaSchema = new Schema { Datum = new DateTime(2024, 6, 5) }; //scehmat
            Kund Sven = new Kund { UserName = "Sven" };
            Kund Kent = new Kund { UserName = "Kent" }; //nya objekt kunder då både sven og kent

            TrainingClass yogaClass = new TrainingClass
            {
                Name = "Yoga för nybörjare", // noob
                TypeOfClass = "Yoga", //vad fär katogeri 
                Trainer = Jacob, //tränaren
                Schema = yogaSchema, // vilket schema
                Deltagare = new List<Kund> { Sven, Kent } //Vilka deltagare som ska vara med 
            };

            yogaClass.ShowUser(); //metod som finns i TrainingClass


        }
    }
}
