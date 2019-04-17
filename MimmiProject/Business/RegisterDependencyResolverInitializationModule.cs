using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using System.Web.Mvc;
using EPiServer.ServiceLocation;

namespace MimmiProject.Business
{
    [InitializableModule]
    [ModuleDependency(typeof(EPiServer.Web.InitializationModule))]
    public class RegisterDependencyResolverInitializationModule : IConfigurableModule
    {
        public void ConfigureContainer(ServiceConfigurationContext context)
        {
            DependencyResolver.SetResolver(
             new StructureMapDependencyResolver(context.StructureMap()));
            //Implementations for custom interfaces can be registered here.
            context.ConfigurationComplete += (o, e) =>
            {

            };
        }

        public void Initialize(InitializationEngine context)
        {
            //Add initialization logic, this method is called once after CMS has been initialized
        }

        public void Uninitialize(InitializationEngine context)
        {
            //Add uninitialization logic
        }
    }
}