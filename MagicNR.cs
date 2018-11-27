using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ND_MagicNR
{
    class Program
    {

        static void Main(string[] args)
        {
            //Console.WriteLine(intToArray());
            //Console.ReadLine();
        }

        //f-ja IntToArray

        public static int[] IntToArray(int x)
        {
            List<int> result = new List<int>();

            while (x != 0)
            {
                result.Add(x % 10);
                x /= 10;
            }

            return result.ToArray();
        }


        //f-ja ArrayValuesDifferent

        public static bool CheckArrayValuesDifferent(int[] values)
        {

            for (int i = 0; i < values.Length - 1; i++)

            {
                int search = values[i];

                for (int j = i + 1; j < 6; i++)
                {
                    if (search == values[i])
                        return false;
                }
            }
            return true;
        }

        //f-ja CompareTwoArrays

        public static bool CompareTwoArrays(int[] Array1, int[] Array2)
        {
            if //
        }
    }
}




