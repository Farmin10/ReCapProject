using System;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemoryCarDal;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            BrandManager carManager = new BrandManager(new EfBrandDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.BrandName);
            }
        }
    }
}
