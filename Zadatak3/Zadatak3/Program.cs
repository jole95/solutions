using System;
using System.Linq;

namespace Zadatak3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] niz1 = new int[] { 2, 4, 5}; // input
            int b = 3; // input 
            int sum = 0;
            int razlika = b - sum;
            int br = 0;
            while (razlika <= b && razlika > 0)
            {
                int maxi = PronadjiOdgovarajuciMax(niz1, razlika);
                sum = sum + maxi;
                razlika = b - sum;

                if(maxi == 0)
                {
                    br = 0;
                    break;
                }               
                br++;
            }
            if (br == 0)
                br = -1; // zbog ispisa

            Console.WriteLine(string.Format("Output: {0}", br));

            static int PronadjiOdgovarajuciMax(int[] array, int razlika)
            {
                int max = 0; 
                foreach (int element in array)
                {
                    if (element > max && element <= razlika)
                    {
                        max = element;
                    }
                }
                return max;
            }
           
            Console.ReadKey();
        }
    }
}
