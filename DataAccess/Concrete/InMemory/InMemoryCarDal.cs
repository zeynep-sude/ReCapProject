using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId=1,BrandId=1,ColorId=1,ModelYear=2016,DailyPrice=349500,Description="2016 model CLİO 1.5 dizel manuel joy paket. Aracımda hata boya değişen hasar kaydı yoktur."},
                new Car{CarId=2,BrandId=1,ColorId=3,ModelYear=2018,DailyPrice=507450,Description="Kaporta ekspertizli ve kilometre garantili.Sorunsuz ikinci el ve sıfır alım satım galerisi"},
                new Car{CarId=3,BrandId=2,ColorId=2,ModelYear=2018,DailyPrice=1530000,Description="ARACIM KAPALI GARAJDA MUHAFAZA EDİLMİŞ OLUP, ÖZENLE KULLANILMIŞTIR."},
                new Car{CarId=4,BrandId=3,ColorId=3,ModelYear=2015,DailyPrice=286000,Description="araç tamamen orjinal değişen parça yoktur motor yürür mekanik hatasız iç döşemeleri sıfır gibi lastikler iyi araçı istediğiniz servise gôsterebilirsiniz ekispere açıktır"}
            };

        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => car.CarId == c.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int brandId)
        {
            return _cars.Where(c => c.BrandId == brandId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => car.CarId == c.CarId);
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
