using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinValue
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] arrayInt = {1, 2, 3, 4, -1, -4, 10};
            int minvalue = GetMinValue(arrayInt);

            Console.WriteLine(minvalue);

            Console.ReadKey();
        }

        public static int GetMinValue(int[] array)
        {
            int min = 0;

            foreach (var item in array)
            {
                if (min > item)
                {
                    min = item;
                }
            }

            return min;
        }
    }  
}
