using System;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.InMemoryCarDal;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var car in carManager.GetList())
            {
                Console.WriteLine(car.Description);
            }
        }
    }
}
