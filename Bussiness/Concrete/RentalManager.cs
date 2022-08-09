using Bussiness.Abstract;
using Bussiness.Constans;
using Core.Untilities.Result.Abstract;
using Core.Untilities.Results.Abstract;
using Core.Untilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult Add(Rental rental)
        {
            if (rental.RentDate != rental.ReturnDate)
            {
                return new ErrorResult(Messages.CarRented);
            }
            _rentalDal.Add(rental);
            return new SuccessResult();
            
        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult();
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());
        }

        public IDataResult<Rental> GetRentDate(DateTime rentDate)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(r => r.RentDate == rentDate ),Messages.CarRented);
        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult();
        }
    }
}
