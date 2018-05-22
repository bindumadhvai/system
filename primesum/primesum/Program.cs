using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter one number");
            int number = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[number / 2];
            Program p = new Program();
            int l = 0;
            for (int i = 3; i < number; i++)
            {
                if (Prime(i) == 1)  
                    // Checks whether i value is prime or not
                {
                    array[l] = i;  
                    //If number is prime then it is stored in array
                    int sum = 0;
                    for (int j = 0; j < l; j++)  
                        // Calculate sum of array elements
                    {
                        sum = sum + array[j];
                    }
                    sum = sum + 2;
                   if ((Prime(sum) == 1) && sum<=number) 
                        // Checks whether sum is prime and less than given input
                    { Console.WriteLine(sum); }      
                   //Prints on console if condtion is satisfied
                    l = l + 1;
                 }
            }
            int Prime(int value)
            { 
                if (value <= 2) return 0;
                for (int i = 2; i < value ; i++)
                {
                    if (value % i == 0)
                    {
                        return 0;
                    }
                }
                return 1;
            }
        }

    }
}
                
    

