using System;

namespace UPPGIFT_1___AFFISCHUTSKICKET
{
    class Program
    {
        static void Main(string[] args)
        {
            Paper letter = new Paper("C4", 229, 324);
            Paper poster = new Paper("A3", 297, 420);
            Paper informationPage = new Paper("A4", 210, 297);

            const int posterAmnt = 2;


            Console.WriteLine("Skriv in vikten på pappret du vill använda i form av (gram/kvadratmeter)");
            Console.Write("Vikt för brevet: ");
            string letterWeight = Console.ReadLine();
            Console.Write("Vikt för affisherna: ");
            string posterWeight = Console.ReadLine();
            Console.Write("Vikt för informationsbladet: ");
            string informationPageWeight = Console.ReadLine();

            float totalWeight = 0;
            totalWeight += letter.GetWeight(int.Parse(letterWeight));
            totalWeight += poster.GetWeight(int.Parse(posterWeight)) * posterAmnt;
            totalWeight += informationPage.GetWeight(int.Parse(informationPageWeight));

            Console.WriteLine("Totala vikten blir: " + totalWeight + " gram");
        }
    }
}
