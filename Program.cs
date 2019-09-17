using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace CodingProblem1
{
    class Program
    {
        static void Main(string[] args)
        {
            String cont = "yes";
            String s;
            do
            {
                Console.Write("Please input a range of numbers: ");
                s = Console.ReadLine();
                String o = output(s);
                Console.WriteLine("This is all the numbers in the given range/set: " + o);
                Console.Write("Would you like to try again? Please type \"Yes\" if so: ");
                cont = Console.ReadLine();
            }
            while (cont.ToLower().Equals("yes"));
            Console.Write("Thanks!");
            Console.ReadLine();
        }

        public static String output(String input)
        {
            String outputted = "";
            string[] intArray = input.Split(',');
            foreach (String s in intArray)
            {
                if (s.IndexOf('-') >= 0)
                {
                    string[] arr = s.Split('-');
                    int first = Convert.ToInt32(arr[0]);
                    int sec = Convert.ToInt32(arr[1]);
                    while (first <= sec)
                    {
                        outputted += first + ",";
                        first++;
                    }

                } else
                    outputted += s + ",";
            }
            Debug.WriteLine(outputted);
            return outputted.Substring(0, outputted.Length - 1);
        }
    }
}
