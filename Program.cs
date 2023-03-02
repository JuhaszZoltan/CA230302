namespace CA230302
{
    internal class Program
    {
        static Random random = new();
        static void Main(string[] args)
        {
            Console.Write("írd be a neved: ");
            string nev = Console.ReadLine();
            Console.WriteLine($"Szia, {nev}!");

            Console.WriteLine($"Várod már a C# órákat, {nev}?");
            string valasz = Console.ReadLine();

            if (valasz == "igen") Console.WriteLine("van egy jó hírem, innentől már csak az lesz....");
            else Console.WriteLine("hát... az baj :(");

            ConsoleColor[] szinek = {
                ConsoleColor.Red,
                ConsoleColor.Green,
                ConsoleColor.Blue,
                ConsoleColor.Yellow };

            foreach (ConsoleColor szin in szinek)
            {
                Console.ForegroundColor = szin;
                Console.WriteLine(nev);
            }

            valasz = null;
            while (valasz != "nem")
            {
                Console.WriteLine("Akarsz még még egy sort?");
                valasz = Console.ReadLine();  
                Console.ForegroundColor = szinek[random.Next(0, 4)];
            }

            for (int i = 0; i < 10; i += 1)
            {
                Console.WriteLine($"az i értéke: {i}");
            }


        }
    }
}