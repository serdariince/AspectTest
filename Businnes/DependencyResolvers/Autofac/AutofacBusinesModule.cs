using System.Reflection;
using Autofac;
using Autofac.Extras.DynamicProxy;
using Businnes.Abstract;
using Businnes.Contrete;
using Castle.DynamicProxy;
using Core.Aspect;
using Core.Aspect.Autofac;
using Core.Utilities.Interceptors;
using DataAccess.Abstrast;
using DataAccess.Concrete;
using Module = Autofac.Module;

namespace Businnes.DependencyResolvers.Autofac
{
    public class AutofacBusinesModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<TesisManager>().As<ITesisServices>();
            builder.RegisterType<EfTesisDal>().As<ITesisDal>();

            builder.RegisterType<KameraManager>().As<IKameraServices>();
            builder.RegisterType<EfKameraDal>().As<IKameraDal>();

            builder.RegisterType<KayitProgramiManager>().As<IKayitProgramiServices>();
            builder.RegisterType<EfKayitProgramiDal>().As<IKayitProgramiDal>();

            builder.RegisterType<Serilogger>().As<ILogger>();

            var assembly = Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}