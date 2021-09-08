using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carM = new CarManager(new InMemoryCarDal());

            foreach (var car in carM.GetAll())
            {
                Console.WriteLine(car.CarId);
            }
            Console.WriteLine("---");
            Car car1 = new Car { CarId = 2, BrandId = 1, ColorId = 1,CarName="Audi", ModelYear = 2020, DailyPrice = 200, Description = "kiralik" };
            Car car2 = new Car { CarId = 3, BrandId = 1, ColorId = 1, CarName = "Audi", ModelYear = 2020, DailyPrice = 200, Description = "kiralik" };

            carM.Add(car1);
            carM.Add(car2);
            foreach (var car in carM.GetAll())
            {
                Console.WriteLine(car.CarId);
            }
            Console.WriteLine("---");

            Console.WriteLine(carM.GetById(2).CarId);
           
            Console.WriteLine("---");
            foreach (var car in carM.GetAll())
            {
                Console.WriteLine(car.CarId);
            }


        }
    }
}
