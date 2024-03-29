[assembly: WebActivator.PostApplicationStartMethod(typeof(SportsStore.WebUI.App_Start.SimpleInjectorInitializer), "Initialize")]

namespace SportsStore.WebUI.App_Start
{
    using System.Reflection;
    using System.Web.Mvc;

    using SimpleInjector;
    using SimpleInjector.Extensions;
    using SimpleInjector.Integration.Web;
    using SimpleInjector.Integration.Web.Mvc;
    using SportsStore.Domain.Abstract;
    using SportsStore.Domain.Temp;
    using SportsStore.Domain.Concrete;
    
    public static class SimpleInjectorInitializer
    {
        /// <summary>Initialize the container and register it as MVC3 Dependency Resolver.</summary>
        public static void Initialize()
        {
            // Did you know the container can diagnose your configuration? Go to: https://bit.ly/YE8OJj.
            var container = new Container();
            
            InitializeContainer(container);

            container.RegisterMvcControllers(Assembly.GetExecutingAssembly());
            
            container.Verify();
            
            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
        }
     
        private static void InitializeContainer(Container container)
        {
            container.Register<IProductRepository, EFProductRepository>();

            // For instance:
            // container.Register<IUserRepository, SqlUserRepository>();
        }
    }
}