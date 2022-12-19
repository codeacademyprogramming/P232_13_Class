using System;

namespace Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fullname = "Hikmet Abbasov";
            byte age = 45;

            string name = "Hikmet";
            string[] words = new string[] { "TOfiq","Nermin",name};

            var car1 = new
            {
                Brand = "Mercedes",
                Model = "E200",
                Price = 44000
            };

            var car2 = new
            {
                Brand = "BMW",
                Model = "X5",
                Price = 40000
            };

            var car3 = new
            {
                Year = 2005,
                Brand = "Lexus"
            };
            

            Console.WriteLine($"{car1.Brand} - {car1.Model} - {car1.Price}");

            var human1 = new
            {
                Fullname = "Hikmet Abbas"
            };

            var human2 = new
            {
                Name = "fdf",
                Surname = "dfd"
            };

            Human hmn1 = new Human();

            hmn1.Name = "Hikmet";
            hmn1.Surname = "Abbasov";

            hmn1.Name = "Abbas";


            Human hmn2 = new Human()
            {
                Name = "Nermin",
                Surname = "Memmedova",
                Age = 18
            };

            hmn2.Age = 30;



            Console.WriteLine($"{hmn1.Name} {hmn1.Surname} {hmn1.Age}");
            Console.WriteLine($"{hmn2.Name} {hmn2.Surname} {hmn2.Age}");


            Human[] humans = new Human[] { hmn1, hmn2, new Human { Name = "Tofiq", Surname = "Melikov", Age = 55 } };

            Console.WriteLine("Humans:");
            for(int i=0;i<humans.Length; i++)
            {
                Console.WriteLine($"{humans[i].Name} {humans[i].Surname} {humans[i].Age}");
            }

            Car car11 = new Car
            {
                Brand = "Mercedes",
                Model = "E200",
                Price = 25000,
                Year = 2008
            };

            Car car12 = new Car();
            car12.Brand = "BMW";
            car12.Model = "X6";
            car12.Price = 5500;
            car12.Year = 2020;

            Car car13 = new Car
            {
                Brand = "Toyota",
                Model = "Prius",
                Price = 50000,
                Year = 2010
            };

            car13.Drive(30);
            car13.Drive(15);
            car13.ResetMillage();

            Console.WriteLine(car12.GetInfo());
            Console.WriteLine(car13.GetInfo());


            Car[] cars = { car11, car12, car13, new Car { Brand = "Lexus", Model = "RX300", Price = 24000, Year = 2018 } };

            var avgPrice = CalcAvg(cars);

            Console.WriteLine("Ortalama qiymet: "+avgPrice);


            Human hmn11 = new Human
            {
                Name = "Hikmet",
                Surname = "Abbasov",
                Age = 35
            };

            Console.WriteLine(hmn11.GetFullname());
        }

        static double CalcAvg(Car[] arr)
        {
            double sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i].Price;
            }

            return sum / arr.Length;
        }
    }
}
