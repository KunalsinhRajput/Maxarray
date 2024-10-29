using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maxarray
{
    class Program
    {
        public static void Main(string[] args) 
        {
            int[] x = new int[5];


            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine("Enter number");
                x[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            int max = x[0];
            for (int i = 0; i <x.Length; i++)
            {
              
                if (x[i] > max)
                {
                    max = x[i];
                }
                
            }
            Console.WriteLine("Maximum number in given array is=" + max);
            Console.ReadLine();
        }
    }
}
