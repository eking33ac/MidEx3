using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidEx3
{
    internal class Program
    {

        // prompt input
        static int[] GetElements()
        {
            // declarations
            int n = 0;


            // have user provide length of the array
            Console.WriteLine("Input length of your array");
            n = Convert.ToInt32(Console.ReadLine());


            // create integer array with user input 'n' as the length
            int[] returnValue = new int[n];
            int nextValue;

            // prompt user to input values
            for (int i = 0; i <n; i++)
            {
                Console.WriteLine("input  value element "+i);
                nextValue = Convert.ToInt32( Console.ReadLine());
                returnValue[i] = nextValue;
            }

            return returnValue; 
            
        }


        // print all ements
        static void PrintElements(int[] userArray)
        {
            Console.WriteLine("All Emlements: ");

            foreach (int i in userArray)
            {
                Console.WriteLine(i);
            }
        }


        // calculate and print the sum of all elements
        static void SumElements(int[] userArray)
        {
            int sum = 0;

            foreach (int i in userArray)
            {
                sum += i;
            }

            Console.WriteLine($"Sum of Elements: {sum}\n");
        }


        // find and print the max and min elements
        static void MaxAndMinElements(int[] userArray)
        {
            int max = Int32.MinValue;
            int min = Int32.MaxValue;

            // get max
            foreach (int i in userArray)
            {
                if (max < i)
                {
                    max = i;
                }
            }

            foreach (int i in userArray)
            {
                if (min > i)
                {
                    min = i;
                }
            }

            Console.WriteLine($"Max Element: {max}\n" +
                $"Min Element: {min}\n");
        }


        // reverse array and print reversed array 



        static void Main(string[] args)
        {
            int[] userArray;

            userArray = GetElements();

            PrintElements(userArray);

            SumElements(userArray);

            MaxAndMinElements(userArray);



            Console.ReadLine();
        }
    }
}
