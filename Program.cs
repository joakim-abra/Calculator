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
                    int chosenOperator = 0;
                    while (chosenOperator < 1 || chosenOperator > 4)
                    {
                        Console.WriteLine("Välj en operator (1-4 eller tecken):");
                        Console.WriteLine("1. +");
                        Console.WriteLine("2. -");
                        Console.WriteLine("3. *");
                        Console.WriteLine("4. /");
                        string choice = Console.ReadLine();
                        switch(choice)
                        {
                            case "1":
                            case "2":
                            case "3":
                            case "4":
                                chosenOperator = Convert.ToInt32(choice);
                                break;
                            case "+":
                                chosenOperator = 1;
                                break;
                            case "-":
                                chosenOperator = 2;
                                break;
                            case "*":
                                chosenOperator = 3;
                                break;
                            case "/":
                                chosenOperator = 4;
                                break;
                            default:
                            Console.WriteLine("Du har gjort ett ogiltigt val!");
                            Console.WriteLine();
                                break;
                        }
                    }
                    return chosenOperator;
                }
                int chosenOperator = OperatorChoice();
                List<char> valAControl = new List<char>() { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
                int i = 0;
                Console.WriteLine();
                Console.Write("Skriv in tal 1: ");
                string valueA = Console.ReadLine();
                while (i < valueA.Length || valueA.Length<1)
                {
                    if (valueA.Length > 0)
                    {
                        foreach (char charValA in valueA)
                        {
                            if (valAControl.Contains(charValA))
                            {
                                i++;
                            }
                            else
                            {
                                Console.WriteLine("Du har angivit ett ogiltigt tal");
                                Console.WriteLine();
                                Console.Write("Skriv in tal 1: ");
                                valueA = Console.ReadLine();
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Du har angivit ett ogiltigt tal");
                        Console.WriteLine();
                        Console.Write("Skriv in tal 1: ");
                        valueA = Console.ReadLine();
                    }

                }
                i = 0;
                Console.Write("Skriv in tal 2: ");
                string valueB = Console.ReadLine();
                while (i < valueB.Length || valueB.Length<1)
                {
                    if (valueB.Length > 0)
                    {
                        foreach (char charValB in valueB)
                        {
                            if (valAControl.Contains(charValB))
                            {
                                i++;
                            }
                            else
                            {
                                Console.WriteLine("Du har angivit ett ogiltigt tal");
                                Console.WriteLine();
                                Console.Write("Skriv in tal 2: ");
                                valueB = Console.ReadLine();
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Du har angivit ett ogiltigt tal");
                        Console.WriteLine();
                        Console.Write("Skriv in tal 2: ");
                        valueB = Console.ReadLine();
                    }
                }
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
                    string selection;
                    int answer = 0;
                    bool loop = true;
                    while (loop)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Välj vad du vill göra: ");
                        Console.WriteLine("1. Se uträkningar");
                        Console.WriteLine("2. Göra ny uträkning");
                        Console.WriteLine("3. Avsluta ");
                        selection = Console.ReadLine();
                        Console.WriteLine();

                        switch (selection)
                        {
                            case "1":
                            case "2":
                            case "3":
                                answer = Convert.ToInt32(selection);
                                loop = false;
                                break;
                            default:
                                Console.WriteLine("Du har angett ett ogiltigt alternativ");
                                break;
                        }
                    }
                    
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
