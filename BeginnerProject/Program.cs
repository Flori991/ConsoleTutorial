using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerProject
{
    class Program
    {
        Rechner rechner = new Rechner();

        static void Main(string[] args)
        {
            Program program = new Program();
            program.Mainmenu();
        }

        public void Mainmenu()
        {
            bool mainBool = true;
            while (mainBool)
            {
                Console.WriteLine("Hallo!");
                Console.WriteLine("(1) Addieren, (2) Subtrahieren, (3) Muliplizieren, (4) Dividieren, (5) Beenden");
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        int resultA = rechner.Addieren();
                        Console.WriteLine($"Ihr Ergebnis ist: {resultA}");
                        Console.ReadKey();
                        break;
                    case "2":
                        int resultS = rechner.Subtrahieren();
                        Console.WriteLine($"Ihr Ergebnis ist: {resultS}");
                        Console.ReadKey();
                        break;
                    case "3":
                        int resultM = rechner.Multiplizieren();
                        Console.WriteLine($"Ihr Ergebnis ist: {resultM}");
                        Console.ReadKey();
                        break;
                    case "4":
                        Result resultD = rechner.Dividieren();
                        Console.WriteLine($"Ihr Ergebnis ist: {resultD.result} Rest: {resultD.remain}");
                        Console.ReadKey();
                        break;
                    case "5":
                        mainBool = false;
                        break;
                    default:
                        break;
                }

            }
        } 
    }
}
