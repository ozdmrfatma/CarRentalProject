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
            CarManager carM = new CarManager(new EfCarDal());

            var result = carM.GetCarDetails();

            foreach (var car in result.Data)
            {
                Console.WriteLine(car.CarName+car.BrandName+car.ColorName+car.DailyPrice);
            }
        }
    }
}
