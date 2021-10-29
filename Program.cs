using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{ 

    class Program
    {
        public static void Display(Massive a)
        {
            foreach (int i in a.Integers)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
        }


        static void Main(string[] args)
        {
            Massive mas = new Massive(1, 12, 4, 5, 3);
            Massive mas2 = new Massive(1, 12, 4, 5, 8);
            Display(mas - mas2);

            Console.WriteLine(mas != mas2);
            Console.WriteLine(StaticOperation.MaxMinDifference(mas));


            Console.WriteLine(StaticOperation.StringExtension.DeleteFirstFiveLtrs("onetwothree"));



            Console.ReadKey();
        }
    }
}
