using Core.DataAccess.EntityFramework;
using Entities.Concrete;
using DataAccess.Concrete.Context;
using DataAccess.Abstract;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfFavoriteDal : EfEntityRepositoryBase<Favorite, PriceMeasurementContext>, IFavoriteDal
    {
    }
}