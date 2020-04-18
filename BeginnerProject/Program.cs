using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();

            program.Anzeige();
        }

        public void Anzeige()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hallo Welt");
            Console.ReadKey();
        }
    }
}
