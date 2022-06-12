using Core.DataAccess.EntityFramework;
using Entities.Concrete;
using DataAccess.Concrete.Context;
using DataAccess.Abstract;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product,PriceMeasurementContext>,IProductDal
    {
    }
}
