using System;
using System.Linq;

namespace Asg2_q2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] l2 = new int[] { 0, 2, 2, 2, 7,7,7,17,50 };

            for (int i = 0; i < (l2.Length-1); i++)
            {


                if (l2[i] > l2[i + 1])
                {
                    l2[i + 1] = l2[i];
                }
                if (l2[i] == l2[i + 1])
                    {
                        
                        l2[i+1] = l2[i] + 1;
                    }
                
               

            }
           
            int sum1 = l2.Sum();
            for (int j = 0; j < l2.Length; j++)
            {
                //Console.WriteLine(sum);
                Console.WriteLine(l2[j]);
                // int final = (sum + l2[j]);
               // sum += l2[j];

                
            }
            Console.Write(sum1);
         
        }
    }
}
