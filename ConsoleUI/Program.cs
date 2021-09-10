using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarTest();

        }

        private static void CarTest()
        {
            Car car1 = new Car { CarId =7, BrandId = 1, ColorId = 1, CarName = "Hundai araba", ModelYear = 2020, DailyPrice = 100, Description = "kiralik" };
            CarManager carM = new CarManager(new EfCarDal());
            carM.Add(car1);

            foreach (var car in carM.GetCarDetails())
            {
                Console.WriteLine(car.CarName+car.BrandName+car.ColorName+car.DailyPrice);
            }
            carM.Delete(car1);
            foreach (var car in carM.GetCarDetails())
            {
                Console.WriteLine(car.CarName);
            }
        }
    }
}
