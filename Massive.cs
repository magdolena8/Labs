using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    class Massive
    {        
        private int[] integers;
        public int[] Integers   //Props
        {  
            get
            {
                return integers;
            }
            set
            {
                integers = value;
            }
        }

        public Massive(params int[] n)  //Constructor
        {
            integers = n;
        }

        public int this [int index] //Indexator
        {
            get
            {
                return integers[index];
            }
        }

        public static Massive operator +(Massive a, Massive b)  //Overloads
        {
            return new Massive {Integers = a.Integers.Concat(b.Integers).ToArray() };
        }


        public static Massive operator -(Massive a, Massive b)
        {
            Massive result = new Massive();
            List<int> termsList = new List<int>();
            foreach (var element in a.Integers)
            {
                if (b.Integers.Contains(element)){
                    continue;
                }
                else
                {
                    termsList.Add(element);
                }
            }
            result.Integers = termsList.ToArray();
            return result;
        }

        public static bool operator >(int a, Massive mas)
        {
            if (mas.Integers.Contains(a))
            {
                return true;
            }
            else return false;
        }
        public static bool operator <(int a, Massive mas)
        {
            throw new Exception("Error: unexpected operator");
            
        }

        public static bool operator !=(Massive mas1, Massive mas2)
        {
            int i = 0;
            foreach (var element in mas1.Integers)
            {
                if (element == mas2.Integers[i])
                {
                    i++;
                    continue;
                }
                else return true;
            }
            return false;
        }

        public static bool operator ==(Massive mas1, Massive mas2)
        {
            int i = 0;
            foreach (var element in mas1.Integers)
            {
                if (element == mas2.Integers[i])
                {
                    i++;
                    continue;
                }
                else return false;
            }
            return true;
        }

        public static class Owner
        {
            public static readonly int id = 37137841;
            public static readonly string name = "Ivan Begansky";
            public static readonly string organization = "BSTU";

            public static class Date
            {
                 public static DateTime creationDate = new DateTime(2021, 10, 09);
            }
        }
    }
    class StaticOperation
    {
        public static int Summ(Massive mass)
        {
            int counter = 0;
            foreach (var i in mass.Integers)
            {
                counter += i;
            }
            return counter;
        }

        public static int MaxMinDifference(Massive mass) => 
            mass.Integers.Max() - mass.Integers.Min();
        public static int Lenght(Massive mass) => 
            mass.Integers.Length;


        public static class StringExtension
        { 
            public static string DeleteVowels(string str)
            {
                char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'а', 'е', 'ё', 'и', 'о', 'у', 'ы', 'э', 'ю', 'я' };
                for (int i = 0; i < str.Length; i++)
                {
                    if (vowels.Contains(str[i]))
                    {
                        str = str.Remove(i, 1);
                        i--;
                    }
                }
                return str;
            }

            public static string DeleteFirstFiveLtrs(string str) =>
                str.Remove(0, 5);
        }
    }
}
