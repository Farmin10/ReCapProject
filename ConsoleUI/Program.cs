using System;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemoryCarDal;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Car car = new Car() {BrandId=2, ColorId=3, DailyPrice = 30000, Description = "Dubay Cars", ModelYear = DateTime.Now };
            carManager.Add(car);
            foreach (var cars in carManager.GetAll())
            {
                Console.WriteLine(cars.DailyPrice);
            }
        }
    }
}
