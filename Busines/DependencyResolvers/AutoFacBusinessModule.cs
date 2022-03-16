using Autofac;
using Autofac.Extras.DynamicProxy;
using Busines.Abstract;
using Busines.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using Core.Utilities.Security.JWT;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule :Module
    {
        protected override void Load(ContainerBuilder builder)
        {


            builder.RegisterType<AdvertCategoryManager>().As<IAdvertCategoryService>().SingleInstance();
            builder.RegisterType<EfAdvertCategoryDal>().As<IAdvertCategoryDal>().SingleInstance();


            builder.RegisterType<AdvertManager>().As<IAdvertService>().SingleInstance();
            builder.RegisterType<EfAdvertDal>().As<IAdvertDal>().SingleInstance();

            builder.RegisterType<BlogManager>().As<IBlogService>().SingleInstance();
            builder.RegisterType<EfBlogDal>().As<IBlogDal>().SingleInstance();

            builder.RegisterType<BlogCategoryManager>().As<IBlogCategoryService>().SingleInstance();
            builder.RegisterType<EfBlogCategoryDal>().As<IBlogCategoryDal>().SingleInstance();

            builder.RegisterType<BlogImageManager>().As<IBlogImageService>().SingleInstance();
            builder.RegisterType<EfBlogImageDal>().As<IBlogImageDal>().SingleInstance();

            builder.RegisterType<AdvertImageManager>().As<IAdvertImageService>().SingleInstance();
            builder.RegisterType<EfAdvertImageDal>().As<IAdvertImageDal>().SingleInstance();

            builder.RegisterType<SubscriberManager>().As<ISubscriberService>().SingleInstance();
            builder.RegisterType<EfSubscribeDal>().As<ISubscriberDal>().SingleInstance();

            builder.RegisterType<ContactManager>().As<IContactService>().SingleInstance();
            builder.RegisterType<EfContactDal>().As <IContactDal>().SingleInstance();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();

        }
    }
}
