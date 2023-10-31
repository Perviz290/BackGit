using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {

         static bool IsPrime(int value)
        {
            bool isComplex = true;
            for (int i = 2; i < value; i++)
            {
                if (value % i == 0)
                {
                    isComplex = false;
                   
                }
            }
            if (isComplex==true)
            {
                return true;
            }
            else {  return false; }      
        }

      static int CalcAvg(params int[] arr)
        {
            int sum = 0;
            int ortalama;
            foreach (int i in arr)
            {
                sum+= i;
            }
            return ortalama = sum / arr.Length;
        }


        static void Main(string[] args)
        {
            Console.WriteLine(IsPrime(15));
            Console.WriteLine(CalcAvg(2, 4, 6));
       
        }
    }
}
