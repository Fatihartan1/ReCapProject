using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Concrete.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal; 
        }

        public void Add(Car car)
        {
            if (car.Description.Length  >2)
            {
                if (car.DailyPrice>0)
                {
                    _carDal.Add(car);
                }
                else
                {
                    Console.WriteLine("Günlük fiyatı 0TL'den fazla olmalıdır");
                }
            }
            else
            {
                Console.WriteLine("Araba açıklaması 2 karakterden uzun olmalıdır");
            }
            
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public Car GetById(int Id)
        {
            return _carDal.Get(p => p.Id == Id);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetailDtos();
        }
        public void Update(Car car)
        {
            _carDal.Uptade(car);
        }
    }
}
