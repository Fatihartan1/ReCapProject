using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarDal
    {
        List<Car> GetById(int Id);
        List<Car> GetAll();
        List<Car> GetByColorId(int colorId);
        List<Car> GroupByDailyPrice();

        void Add(Car car);
        void Delete(Car car);
        void Uptade(Car car);
    }
}
