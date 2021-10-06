using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    /*partial*/public class Airline
    {
        public readonly string id;  //readonly field
        internal string airplaneModel {get;} = "Airbus A380"; //const field
        internal uint airNumber { get; set; }
        internal string destination { get; set; } = "unknown";
        internal string type { get; set; } = "unknown";
        internal string days { get; set; } = "unknown";
        internal double time { get; set; } = double.PositiveInfinity;
        public static uint totalCreated { get; set; } = 0;


        //Methods
        public static void seeClassInfo() //Displays class info
        {
            Console.WriteLine("___Класс Airline управляет объектами(самолетами)___");
        }

        static void addPlain()
        {
            Airline.totalCreated++;
        }
        public /*partial */void seeInfo()
        {
            Console.WriteLine($"ID:\t\t {id}");
            Console.WriteLine($"Airplane model:\t {airplaneModel}");
            Console.WriteLine($"Airplane number: {airNumber}");
            Console.WriteLine($"Destination:\t {destination}");
            Console.WriteLine($"Airplane type:\t {type}");
            Console.WriteLine($"Departure days:\t {days}");
            Console.WriteLine($"Departure time:\t {time}\n\n");
        }


        //Constructors
        public Airline()
        {
            Console.WriteLine("__ВЫ НЕ УКАЗАЛИ ПАРАМЕТРЫ__");
        }
        public Airline(uint airNumber, string destination, string type, string days, double time)
        {
            id = Guid.NewGuid().ToString(); //static contructor
            this.airNumber = airNumber;
            this.destination = destination;
            this.type = type;
            this.days = days;
            this.time = time;
            addPlain();
        }
        public Airline(uint num, string dest)
        {
            id = Guid.NewGuid().ToString(); //static contructor
            airNumber = num;
            destination = dest;
            type = "unknown";
            days = "unknown";
            time = double.NaN;
            addPlain();
        }
        public Airline(uint num)
        {
            id = Guid.NewGuid().ToString(); //static contructor
            airNumber = num;
            destination = "unknown";
            type = "unknown";
            days = "unknown";
            time = double.NaN;
            addPlain();
        }

        //Override
        public override string ToString()
        {
            return ($"{id} {airNumber} {destination} {type} {days} {time}");

        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
    }


    //public partial class Info   //partial Class (display info)
    //{
    //    partial void seeInfo()
    //    {
    //        Console.WriteLine();
    //    }
    //}
}
