using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
namespace Sorting1;
class Program 
{
    public static void Main(string[] args)
    {

            //Bubble sort
            int[] number = { 45,33,12,55,77,22,33,14,67,12,35 };
            bool flag = true;
            int temp;
            int numLength = number.Length;

            //sorting an array
            for (int i = 1; (i <= (numLength - 1)) && flag; i++)
            {
                flag = false;
                for (int j = 0; j < (numLength - 1); j++)
                {
                    if (number[j + 1] > number[j])
                    {
                        temp = number[j];
                        number[j] = number[j + 1];
                        number[j + 1] = temp;
                        flag = true;
                    }
                }
            }
            Array.Reverse(number);

            //Sorted array
            foreach (int num in number)
            {
                Console.Write("\t {0}",num);
            }
            Console.Read();         
    }
}