using Business.Abstract;
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
            //CarTest();

            //UserTest();
        }

        private static void UserTest()
        {
            User user1 = new User { Id = 2, FirstName = "Zehra", LastName = "Özdemir", Email = "zehra@gmail.com", Password = "1234" };
            IUserService userService = new UserManager(new EfUserDal());
            userService.Add(user1);

            ICustomerService customerService = new CustomerManager(new EfCustomerDal());
            Customer customer1 = new Customer { UserId = 2, CompanyName = "Huawei" };
            customerService.Add(customer1);
            var result2 = customerService.GetAll();
            foreach (var customer in result2.Data)
            {
                Console.WriteLine(customer.UserId + customer.CompanyName);
            }
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
