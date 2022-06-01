using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finding_Reverse_of_a_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string continuation;

            do
            {
                long user_num;
                long num;
                long result = 0;
                long remainder;

                Console.Write("Enter the number which u want to reverse: ");
                user_num = Convert.ToInt64(Console.ReadLine());

                num = user_num;

                while (num != 0)
                {
                    remainder = num % 10;
                    result = result * 10 + remainder;
                    num = num / 10;
                }
                Console.WriteLine("{0} is the reverse of {1} \n" +
                        "Press enter to continue", result, user_num);
                Console.ReadLine();
                Console.Write("Do you want to continue? \n" +
                    "Press (y) for yes and (n) for no \n" +
                    ": ");
                continuation = Console.ReadLine();
            } 
            while (continuation == "y" || continuation == "Y" || continuation == "(y)");
        }
    }
}
