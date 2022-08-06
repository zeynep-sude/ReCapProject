using Core.Untilities.Result.Abstract;
using Core.Untilities.Results.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetCarsByBrandId(int id);
        IDataResult<List<Car>> GetCarsByColorId(int id);
        IResult Add(CarDetailDto carDetailDto,Car car);
        IResult CarRemove(Car car);
        IResult  CarDelete(Car car);
        IDataResult<List<CarDetailDto>> GetCarDetails();
    }
}
