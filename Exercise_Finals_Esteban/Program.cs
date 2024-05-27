using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Finals_Esteban
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            List<int> numberList = new List<int>();

            for (int x = 0; x < 500; x++) // GENERATING RANDOM NUMBERS
            {
                numberList.Add(rnd.Next(0,101));
            }

            int num1; // UPPER LIMIT
            int num2; // LOWER LIMIT

            // UPPER LIMIT
            while (true)
            {
                try
                {
                    Console.Write("════════════════════════════════════════════════════\n\nPlease input a number (0 - 100)\nUPPER LIMIT:\t");
                    num1 = int.Parse(Console.ReadLine());

                    // CONDITIONS FOR UPPER LIMIT INPUT
                    if (num1 > 100) 
                    {
                        Console.WriteLine("Input should not be greater than 100. Press Enter to Input Again.");
                    }
                    else if (num1 <= 0) 
                    {
                        Console.WriteLine("Input should not be less than or equal to 0. Press Enter to Input Again.");
                    }
                    else if (num1 >= 0 && num1 <= 100)
                    {
                        Console.WriteLine($"Successful Input. Please press enter to continue.");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    }
                }
                catch (Exception error) // WRONG FORMAT
                {
                    Console.WriteLine("\n" + error.Message + " Please input numbers only.");
                    Console.WriteLine("Press Enter to Input Again.");
                }
                Console.ReadLine();
                Console.Clear();
            }


            // LOWER LIMIT
            while (true)
            {
                Console.WriteLine($"════════════════════════════════════════════════════\n\nUPPER LIMIT:\t{num1}");
                Console.Write($"LOWER LIMIT CANNOT BE GREATER THAN UPPER LIMIT\n\nPlease input a number (0 - 100)\nLOWER LIMIT:\t");
                num2 = int.Parse(Console.ReadLine());

                // CONDITIONS FOR LOWER LIMIT INPUT
                try
                {
                    if (num2 > 100)
                    {
                        Console.WriteLine("Input should not be greater than 100. Press Enter to Input Again.");
                    }
                    else if (num2 < 0)
                    {
                        Console.WriteLine("Input should not be less than or equal to 0. Press Enter to Input Again.");
                    }
                    else if (num2 >= 0 && num2 <= 100 && num2 < num1)
                    {
                        Console.WriteLine($"Successful Input. Press Enter to Continue.");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    }
                    else if (num2 >= num1)
                    {
                        Console.WriteLine("Input should not be greater or equal to the upper limit. Press Enter to Input Again.");
                    }
                }
                catch (Exception error) // WRONG FORMAT
                {
                    Console.WriteLine(error.Message);
                    Console.WriteLine("Press Enter to Input Again.");
                }
                Console.ReadLine();
                Console.Clear();
            }


            // SORTING AND DISPLAYING
            List<int> numbersBetween = new List<int>(); // LIST OF NUMBERS BETWEEN UPPER AND LOWER INPUT
            int temp = 0;

            for (int x = 0; x < numberList.Count; x++) // COLLECTING NUMBERS
            {
                if (numberList[x] < num1 && numberList[x] > num2)
                {
                    numbersBetween.Add(numberList[x]);
                }
            }

            for (int x = 0; x < numbersBetween.Count(); x++) // SORTING NUMBERS
            {
                temp = 0;
                for (int y = 0; y < numbersBetween.Count(); y++)
                {
                    if (numbersBetween[x] < numbersBetween[y])
                    {
                        temp = numbersBetween[x];
                        numbersBetween[x] = numbersBetween[y];
                        numbersBetween[y] = temp;
                    }
                }
            }

            // DISPLAYING NUMBERS
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"- PRESS ENTER TO DISPLAY THE NUMBERS BETWEEN {num2} AND {num1} -");
            Console.ReadLine(); Console.Clear();
            Console.WriteLine($"- DISPLAYING THE NUMBERS BETWEEN {num2} AND {num1} -\n");
            if (numbersBetween.Count == 0)
            {
                Console.WriteLine($"- THERE ARE NO NUMBERS BETWEEN {num2} AND {num1} -");
            }
            else
            {
                for (int x = 0; x < numbersBetween.Count; x++)
                {
                    Console.Write(numbersBetween[x] + "  ");
                }
            } 
            Console.ReadKey();
        }
    }
}
