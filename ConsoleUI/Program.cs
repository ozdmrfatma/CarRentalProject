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
            Car car1 = new Car { CarId = 5, BrandId = 2, ColorId = 1, CarName = "B", ModelYear = 2020, DailyPrice = 100, Description = "kiralik" };
            CarManager carM = new CarManager(new EfCarDal());
            carM.Add(car1);

            foreach (var car in carM.GetCarsByColorId(1))
            {
                Console.WriteLine(car.CarName);
            }



        }
    }
}
