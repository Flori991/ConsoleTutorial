﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerProject
{
    public class Rechner
    {
        private int numberOne;
        private int numberTwo;

       

        public int Addieren()
        {
            while (true)
            {
                Console.WriteLine("Geben sie die erste Zahl ein");
                string userInput = Console.ReadLine();
                if (!Int32.TryParse(userInput, out numberOne))
                {
                    Console.WriteLine("Gebe eine Zahl ein");
                    continue;
                }
                break;
            }

            while (true) 
            { 
                Console.WriteLine("Geben sie die zweite Zahl ein");
                string userInput = Console.ReadLine();
                if (!Int32.TryParse(userInput, out numberTwo))
                {
                    Console.WriteLine("Gebe eine Zahl ein");
                    continue;
                }
                break;
            }

            int result = numberOne + numberTwo;
            return result;
        }
        public int Subtrahieren()
        {
            while (true)
            {
                Console.WriteLine("Geben sie die erste Zahl ein");
                string userInput = Console.ReadLine();
                if (!Int32.TryParse(userInput, out numberOne))
                {
                    Console.WriteLine("Gebe eine Zahl ein");
                    continue;
                }
                break;
            }

            while (true)
            {
                Console.WriteLine("Geben sie die zweite Zahl ein");
                string userInput = Console.ReadLine();
                if (!Int32.TryParse(userInput, out numberTwo))
                {
                    Console.WriteLine("Gebe eine Zahl ein");
                    continue;
                }
                break;
            }

            int result = numberOne - numberTwo;
            return result;
        }

        public int Multiplizieren()
        {
            while (true)
            {
                Console.WriteLine("Geben sie die erste Zahl ein");
                string userInput = Console.ReadLine();
                if (!Int32.TryParse(userInput, out numberOne))
                {
                    Console.WriteLine("Gebe eine Zahl ein");
                    continue;
                }
                break;
            }

            while (true)
            {
                Console.WriteLine("Geben sie die zweite Zahl ein");
                string userInput = Console.ReadLine();
                if (!Int32.TryParse(userInput, out numberTwo))
                {
                    Console.WriteLine("Gebe eine Zahl ein");
                    continue;
                }
                break;
            }

            int result = numberOne * numberTwo;
            return result;
        }

        public Result Dividieren()
        {
            while (true)
            {
                Console.WriteLine("Geben sie die erste Zahl ein");
                string userInput = Console.ReadLine();
                if (!Int32.TryParse(userInput, out numberOne))
                {
                    Console.WriteLine("Gebe eine Zahl ein");
                    continue;
                }
                break;
            }

            while (true)
            {
                Console.WriteLine("Geben sie die zweite Zahl ein");
                string userInput = Console.ReadLine();
                if (!Int32.TryParse(userInput, out numberTwo))
                {
                    Console.WriteLine("Gebe eine Zahl ein");
                    continue;
                }
                break;
            }

            Result result = new Result(numberOne / numberTwo, numberOne % numberTwo);
                       
            return result;
            
        }
    }
}
