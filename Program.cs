using System;
using System.Collections.Generic;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            void Greeting()
            {
                Console.Write("Skriv in ditt namn: ");
                string namn = Console.ReadLine();
                Console.WriteLine("Välkommen till miniräknaren, " + namn);
                Console.WriteLine();
            }

            string Calculator(List<string>calculations)
            {
                List<string> madeCalculations = new List<string>();
                foreach (string item in calculations)
                {
                    madeCalculations.Add(item);
                }
                int OperatorChoice()
                {
                    Console.WriteLine("Välj en operator (1-4):");
                    Console.WriteLine("1. +");
                    Console.WriteLine("2. -");
                    Console.WriteLine("3. *");
                    Console.WriteLine("4. /");
                    int chosenOperator = Convert.ToInt32(Console.ReadLine());
                    return chosenOperator;
                }
                int chosenOperator = OperatorChoice();
                Console.WriteLine();
                Console.Write("Skriv in tal 1: ");
                string valueA = Console.ReadLine();
                Console.Write("Skriv in tal 2: ");
                string valueB = Console.ReadLine();
                double result;
                
                string add;
                if (chosenOperator == 1)
                {
                    result = Convert.ToDouble(valueA) + Convert.ToDouble(valueB);
                    Console.WriteLine("{0} + {1} = {2}", valueA, valueB, result);
                    add = valueA + " + " + valueB + " = " + Convert.ToString(result);
                    
                }
                else if (chosenOperator == 2)
                {
                    result = Convert.ToDouble(valueA) - Convert.ToDouble(valueB);
                    Console.WriteLine("{0} - {1} = {2}", valueA, valueB, result);
                    add = valueA + " - " + valueB + " = " + Convert.ToString(result);
                    
                }
                else if (chosenOperator == 3)
                {
                    result = Convert.ToDouble(valueA) * Convert.ToDouble(valueB);
                    Console.WriteLine("{0} * {1} = {2}", valueA, valueB, result);
                    add = valueA + " * " + valueB + " = " + Convert.ToString(result);
                   
                }
                else
                {
                    result = Convert.ToDouble(valueA) / Convert.ToDouble(valueB);
                    Console.WriteLine("{0} / {1} = {2}", valueA, valueB, result);
                    add = valueA + " / " + valueB + " = " + Convert.ToString(result);
                    
                }
                madeCalculations.Add(add);
                int Menu()
                {
                    Console.WriteLine();
                    Console.WriteLine("Välj vad du vill göra: ");
                    Console.WriteLine("1. Se uträkningar");
                    Console.WriteLine("2. Göra ny uträkning");
                    Console.WriteLine("3. Avsluta ");
                    int answer = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    if (answer == 1)
                    {
                        while (answer == 1)
                        {
                            foreach (string line in madeCalculations)
                            {
                                Console.WriteLine(line);
                            }
                            Console.WriteLine();
                            Console.WriteLine("Välj vad du vill göra: ");
                            Console.WriteLine("1. Se uträkningar");
                            Console.WriteLine("2. Göra ny uträkning");
                            Console.WriteLine("3. Avsluta ");
                            answer = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();
                        }
                    }
                        return answer;
                }
                int menuReturn = Menu();
                if (menuReturn == 3)
                {
                    return "false";
                }
                else
                {
                    return add;
                }
            }
            Greeting();
            List<string> madeCalculations = new List<string>();
            bool run;
            string add;
            do
            {
                add=Calculator(madeCalculations);
                if (add != "false")
                {
                    run = true;
                }
                else
                {
                    run = false;
                }
                madeCalculations.Add(add);
            }
            while (run);
        }
    }
}
