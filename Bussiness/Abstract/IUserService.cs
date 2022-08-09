using Core.Untilities.Result.Abstract;
using Core.Untilities.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Abstract
{
    public interface IUserService
    {
        IDataResult<List<User>> GetAll();
        IDataResult<List<User>> GetUserByCustomerId(int userId);
        IResult Add(User user); 
        IResult Update(User user);
        IResult Delete(User user);
    }
}
