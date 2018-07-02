using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(BinaryToDecimal("1001"));

            Console.ReadKey();

        }

        static int BinaryToDecimal(string binary)
        {

            int answer = 0;
            int count = 1;

            for (int i = binary.Length - 1;i >= 0; i--)
            {

                if (binary.Substring(i,1) == "1")
                {
                    answer = answer + count;
                }

                count *= 2;

            }


            return answer ;

        }

    }
}
