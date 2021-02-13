using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemoryCarDal
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars = null;
        public InMemoryCarDal()
        {
            _cars = new List<Car>(){
                    new Car{ CarId=1,BrandId=1,ColorId=2,DailyPrice=25643,ModelYear=DateTime.Now,Description="Very good car"},
                    new Car { CarId=2,BrandId=1,ColorId=5,DailyPrice=32563,ModelYear=DateTime.Now,Description="Very strong car"},
                    new Car { CarId=3,BrandId=1,ColorId=4,DailyPrice=25635,ModelYear=DateTime.Now,Description="Very expensive car"},
                    new Car { CarId=4,BrandId=2,ColorId=2,DailyPrice=25063,ModelYear=DateTime.Now,Description="modern car"},
                    new Car { CarId=5,BrandId=2,ColorId=1,DailyPrice=25603,ModelYear=DateTime.Now,Description="new car"}
             };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car deleteCar = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            _cars.Remove(deleteCar);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetByBrandId(int brandId)
        {
            return _cars.Where(p => p.BrandId == brandId).ToList();
        }

        public void Update(Car car)
        {
            Car updateCar = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            updateCar.BrandId = car.BrandId;
            updateCar.Description = car.Description;
            updateCar.DailyPrice = car.DailyPrice;
            updateCar.ColorId = car.CarId;
        }
    }
}
