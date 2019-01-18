using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amadeus_Martinez_Mod1_Lab1B_section01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[9] { 1, 4, 13, 43, -25, 17, 22, -37, 29 };
            Console.WriteLine(nums.findLargest());
        }

        public static int findLargest(int[] array)
        {

            int index = 0;
            int maxInt = Int32.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                int value = array[i];
                if (value > maxInt)
                {
                    maxInt = value;
                    index = i;

                    
                }
                return maxInt;
            }
            
    }
}
