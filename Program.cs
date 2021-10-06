using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    //partial class Airline //partial Class (display info)
    //{
    //    public partial void seeInfo();
    //}





    class Program
    {
        public static void searchDestination(Airline[] flights)
        {
            Console.Clear();
            Console.Write("Write airplane destination: ");
            string city = Console.ReadLine().ToString();
            foreach(Airline flight in flights)
            {
                if (flight.destination == city)
                {
                    flight.seeInfo();
                    //return;
                }
            }
            Console.ReadKey();
        }

        public static void searchDays(Airline[] flights)
        {
            Console.Clear();
            Console.Write("Write race day: ");
            string day = Console.ReadLine().ToString();
            foreach (Airline flight in flights)
            {
                string[] subs = flight.days.Split(' ');
                foreach (var str in subs)
                {
                    if(str == day)
                    {
                        flight.seeInfo();
                    }
                }
            }
            Console.ReadKey();
        }


        static void Main(string[] args)
        {
            Airline[] flights = new Airline[5];

            flights[0] = new Airline(144, "Paris", "Econom", "Mon Wed Fri", 12.15);
            flights[1] = new Airline(228, "Kiev", "Econom", "Mon  Fri", 10.15);
            flights[2] = new Airline(44, "Berlin", "Econom", "Mon Wed Fri", 6.45);
            flights[3] = new Airline(653, "Paris", "Buisness", "Sun Mon", 10.45);
            flights[4] = new Airline(813, "London", "Buisness", "Mon Wed Sat Sun", 22.30);
            searchDestination(flights);
            searchDays(flights);


            Console.ReadKey();
        }
    }
}
