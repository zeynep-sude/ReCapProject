using Bussiness.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Concrete
{
    public class CarManager : ICarServise
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        
        public void CarAdd(Brand brand, Car car)
        {
            if (car.DailyPrice > 0 && brand.BrandName.Length>2)
            {
                _carDal.Add(car);
                Console.WriteLine("Araba Eklendi");
            }
            else
            {
                Console.WriteLine("Araba Eklenemedi");
            }
        }

        public List<Car> GetAll()
        {
           return _carDal.GetAll();
        }

      

        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll(c => c.BrandId == id);
        }

  
        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.GetAll(c => c.ColorId == id);
        }
    }
}
