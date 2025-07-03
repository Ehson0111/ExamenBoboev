
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ExamenBoboev
{


    public class MaxMin
    {


        public static int NMax(double[] A, int N)
        {

            if (A.Length==0||N==0)
            {
                throw new ArgumentException("Введите корректные входные данные");
            }

            int maxindex = 0;
            for (int i = 0; i < N; i++)
            {

                if (A[i] > A[maxindex])
                {
                    maxindex = i;
                }

            }
            return maxindex;


        }
        public static int NMin(double[] A, int N)
        {
            
            if (A.Length==0||N==0)
            {
                throw new ArgumentException("Введите корректные входные данные");
            }

            int minindex = 0;
            for (int i = 0; i < N; i++)
            {

                if (A[i] < A[minindex])
                {
                    minindex = i;
                }

            }
            return minindex;
        }


    }
    public class Program
    {


        public static void Main()
        {

            MaxMin arrayHelper = new MaxMin();
            double[] f = { 2, 4, 5, 6, 7, 8 };
            int s = MaxMin.NMax(f, f.Length);
            Console.WriteLine("Индекс максимального число в масиве "+s);


            int s1 = MaxMin.NMin(f, f.Length);
            Console.WriteLine("Индекс минимального число в масиве "+s1);
        }
    }
}


