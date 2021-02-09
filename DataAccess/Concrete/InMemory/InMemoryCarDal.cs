using Core.DataAcces;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Concrete.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car {Id=1 , ColorId=1 , BrandId = 1, DailyPrice =18000, ModelYear = 1996 ,Description="Ford Mustang"},
                new Car {Id=2, ColorId=2, BrandId = 3, DailyPrice=25000, ModelYear = 2018, Description ="BMW M4"},
                new Car {Id=3, ColorId=2, BrandId = 2, DailyPrice= 5000, ModelYear = 2012, Description ="Nissan Datsun 450z"},
                new Car {Id=4, ColorId=3, BrandId = 1, DailyPrice=15000, ModelYear = 2016, Description ="Ww Golf"},
                new Car {Id=5, ColorId=4, BrandId = 5, DailyPrice=35000, ModelYear = 2021, Description ="Mercedes S350"},

            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car CarsToDelete = _cars.SingleOrDefault(p => p.Id == car.Id);
            _cars.Remove(CarsToDelete);
        }

        public List<Car> Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetByColorId(int colorId)
        {
            return _cars.Where(p => p.ColorId == colorId).ToList();
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(p => p.Id == Id).ToList();
        }

        public List<CarDetailDto> GetCarDetailDtos()
        {
            throw new NotImplementedException();
        }

        public List<Car> GroupByDailyPrice()
        {
            return _cars.OrderBy(p => p.DailyPrice).ToList();
        }

        public void Uptade(Car car)
        {
            Car CarsToUpdate = _cars.SingleOrDefault(p => p.Id == car.Id);
            CarsToUpdate.BrandId = car.BrandId;
            CarsToUpdate.ColorId = car.ColorId;
            CarsToUpdate.DailyPrice = car.DailyPrice;
            CarsToUpdate.Id = car.Id;
            CarsToUpdate.Description = car.Description;
            CarsToUpdate.ModelYear = car.ModelYear;
        }

        Car IEntityRepository<Car>.Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
