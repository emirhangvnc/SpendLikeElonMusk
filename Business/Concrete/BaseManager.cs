using Core.Entities;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public abstract class BaseManager<T>
    {
        public abstract IDataResult<List<T>> GetAll();
    }
}
