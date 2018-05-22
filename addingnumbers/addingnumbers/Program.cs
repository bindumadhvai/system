using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER FRIST NUMBER ");
            var number1 = Console.ReadLine();
            Console.WriteLine("ENTER SECOND NUMBER ");
            var number2 = Console.ReadLine();
            Program p = new Program();
            p.Add(number1, number2);
        }
        void Add(String number1, String number2)
        {
            int n2 = number2.Length;
            int n1 = number1.Length;
            var r = new StringBuilder();
            var result = new StringBuilder();
            if (n1 > n2)
            {
                number2 = number2.PadLeft(n1, '0');
            }
            else
            {
                number1 = number1.PadLeft(n2, '0');
            }
            int carry = 0;
            for (int i = number1.Length - 1; i >= 0; i--)
                //This block calculates sum of individual integers in string and add carry if any.
            {
                int val1 = Convert.ToInt32(number1.Substring(i, 1));
                int val2 = Convert.ToInt32(number2.Substring(i, 1));
                int sum = val1 + val2 + carry;
                carry = 0;
                if (sum > 9)
                {
                    carry = 1;
                    sum = sum - 10;
                }
                r.Append(sum);
            }
            if (carry == 1)
            {
                result.Append(1);
            }
            for(int i = number1.Length - 1; i >= 0; i--)
            {
                result.Append(r[i]);
            }
            Console.WriteLine(result);
        }
    }
}

