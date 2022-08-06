using Core.Untilities.Result.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Untilities.Results.Abstract
{
    public interface IDataResult<T>:IResult
    {
        T Data { get;  }
    }
}
