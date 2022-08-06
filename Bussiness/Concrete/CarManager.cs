using Bussiness.Abstract;
using Bussiness.Constans;
using Core.Untilities.Result.Abstract;
using Core.Untilities.Results.Abstract;
using Core.Untilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        
        public IResult Add(CarDetailDto carDetailDto,Car car) 
        {
            if (carDetailDto.BrandName.Length<2 && car.DailyPrice==0)
            {
                return new ErrorResult(Messages.BrandNameInvalid+ " "+Messages.CarDailyPrice);
            }
           _carDal.Add(car);
            return new Result(true,"Ürün Eklendi");
        }

        public IResult CarDelete(Car car)
        {
            throw new NotImplementedException();
        }

        public IResult CarRemove(Car car)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Car>> GetAll()
        {
            if (DateTime.Now.Hour == 01)
            {
                return new ErrorDataResult<List<Car>>(Messages.MainTenanceTime);
            }
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Messages.CarListed);
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            if (DateTime.Now.Hour == 2)
            {
                return new ErrorDataResult<List<CarDetailDto>>(Messages.MainTenanceTime);
            }
            return new SuccessDataResult<List<CarDetailDto>> ( _carDal.GetCarDetails());
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int id)
        {
            return new SuccessDataResult<List<Car>>( _carDal.GetAll(c => c.BrandId == id));
        }

  
        public IDataResult<List<Car>> GetCarsByColorId(int id)
        {
            return new SuccessDataResult<List<Car>>( _carDal.GetAll(c => c.ColorId == id));
        }
    }
}
