using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsciiConversion
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Enter a string");
            String sstring = Console.ReadLine();
           Program p = new Program();
           p.Conversion(sstring);
        }
        void Conversion(String sstring)
        {
           int i = 0;
           int[] array = new int[30];
           foreach (char c in sstring)    
                //Converting each character of string into its ascii values.
           {
              array[i] = Convert.ToInt32(c);
              i++;
           }
           Console.WriteLine("Values before checking prime");
           for (int j = 0; j < i-1; j++)
           {
              int flag = 0;
              array[j] = (array[j] + array[j + 1]) / 2;
              Console.Write(array[j] + "  ");    
                //Printing average of two ascii values.
              for (int k = 2; k < array[j] / 2; k++)  
                    //This block i checking for prime number.
              {
                  if (array[j] % k == 0)
                      flag = 1;
              }
                if (flag == 0)
                {
                    //This block will increment value by 1 if it is prime number.
                    array[j] = array[j] + 1;
                }
           }
           Console.WriteLine();
           Console.WriteLine("Values after checking prime");
           for (int l = 0; l < i-1; l++)
           {
               Console.Write(array[l] + " ");  
                //This block will display final values.
           }
           Console.WriteLine("Equivalent string is ");
           for (int k = 0; k < i-1; k++)
           {
               Console.Write(Convert.ToChar(array[k]) + "");   
                //This block will display eqivalent characters of final values.
           }
           Console.WriteLine();
        }
    }
}

   
