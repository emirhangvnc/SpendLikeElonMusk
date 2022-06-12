using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.Ninject
{
    public class NinjectBusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ICategoryService>().To<CategoryManager>().InSingletonScope();
            Bind<ICategoryDal>().To<EfCategoryDal>().InSingletonScope();

            Bind<ICompanyWealthService>().To<CompanyWealthManager>().InSingletonScope();
            Bind<ICompanyWealthDal>().To<EfCompanyWealthDal>().InSingletonScope();

            Bind<IFavoriteService>().To<FavoriteManager>().InSingletonScope();
            Bind<IFavoriteDal>().To<EfFavoriteDal>().InSingletonScope();

            Bind<IFortuneService>().To<FortuneManager>().InSingletonScope();
            Bind<IFortuneDal>().To<EfFortuneDal>().InSingletonScope();

            Bind<IPersonalWealthService>().To<PersonalWealthManager>().InSingletonScope();
            Bind<IPersonalWealthDal>().To<EfPersonalWealthDal>().InSingletonScope();

            Bind<IProductService>().To<ProductManager>().InSingletonScope();
            Bind<IProductDal>().To<EfProductDal>().InSingletonScope();
        }
    }
}
