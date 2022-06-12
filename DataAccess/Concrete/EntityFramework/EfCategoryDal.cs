using Core.DataAccess.EntityFramework;
using Entities.Concrete;
using DataAccess.Concrete.Context;
using DataAccess.Abstract;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, PriceMeasurementContext>, ICategoryDal
    {
    }
}
