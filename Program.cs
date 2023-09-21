
using System.Linq;
using ResemålApp;

internal class Program
{
    static bool running = true;

    private static void Main(string[] args)
    {
        List<Resemål> ReseLogg = new();

        while (running)
        {

            Console.WriteLine("Välkommen! Välj ett alternativ:");
            Console.WriteLine("1. Lägg till resmål");
            Console.WriteLine("2. Visa alla resmål");
            Console.WriteLine("3. Visa totala avståndet");
            Console.WriteLine("4. Ta bort alla resmål");
            Console.WriteLine("Q. Avsluta programmet");

            string userInput = Console.ReadLine();

            if (userInput == "1")
            {
                Resemål nyttResemål = new();

                Console.WriteLine("Ange startdatum:");
                nyttResemål.StartDatum = Console.ReadLine();

                Console.WriteLine("Ange slutdatum:");
                nyttResemål.SlutDatum = Console.ReadLine();

                Console.WriteLine("Ange destination:");
                nyttResemål.Destination = Console.ReadLine();

                Console.WriteLine("Ange Avstånd (i kilometer):");
                nyttResemål.Avstånd = float.Parse(Console.ReadLine());

                Console.WriteLine("Ange restid (Ange i minuter):");
                nyttResemål.Restid = float.Parse(Console.ReadLine());

                Console.WriteLine("Ange Övriga kostnader:");
                nyttResemål.ÖvrigaKostnader = float.Parse(Console.ReadLine());

                ReseLogg.Add(nyttResemål);

            }
            else if (userInput == "2")
            {
                foreach (Resemål item in ReseLogg)
                {
                    Console.WriteLine(item);
                }
            }

            else if (userInput == "3")
                CalculateTotalDistance(ReseLogg);

            else if (userInput == "4")
                ReseLogg.Clear();

            else if (userInput == "q")
                QuitProgramme();

            else
                Error(userInput);

        }


        static void QuitProgramme()
        {
            Console.WriteLine("4. Avsluta programmet");
            running = false;
        }

        static void Error(string userInput)
        {
            Console.WriteLine($"Ogiltig input, {userInput}");
        }

        static void CalculateTotalDistance(List<Resemål> ReseLogg) =>
            Console.WriteLine($"Det totala avståndet är: {ReseLogg.Select(resmål => resmål.Avstånd).Sum()} kilometer");

        //float totalDistance = 0;

        //foreach (Resemål resmål in ReseLogg)
        //{
        //    totalDistance += resmål.Avstånd;
        //}

        //Console.WriteLine($"Det totala avståndet är: {totalDistance} kilometer");


    }
}