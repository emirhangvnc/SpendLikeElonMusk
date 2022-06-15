using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ICategoryService>().As<CategoryManager>().SingleInstance();
            builder.RegisterType<ICategoryDal>().As<EfCategoryDal>().SingleInstance();

            builder.RegisterType<ICompanyWealthService>().As<CompanyWealthManager>().SingleInstance();
            builder.RegisterType<ICompanyWealthDal>().As<EfCompanyWealthDal>().SingleInstance();

            builder.RegisterType<IFavoriteService>().As<FavoriteManager>().SingleInstance();
            builder.RegisterType<IFavoriteDal>().As<EfFavoriteDal>().SingleInstance();

            builder.RegisterType<IFortuneService>().As<FortuneManager>().SingleInstance();
            builder.RegisterType<IFortuneDal>().As<EfFortuneDal>().SingleInstance();

            builder.RegisterType<IPersonalWealthService>().As<PersonalWealthManager>().SingleInstance();
            builder.RegisterType<IPersonalWealthDal>().As<EfPersonalWealthDal>().SingleInstance();

            builder.RegisterType<IProductService>().As<ProductManager>().SingleInstance();
            builder.RegisterType<IProductDal>().As<EfProductDal>().SingleInstance();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();
            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}