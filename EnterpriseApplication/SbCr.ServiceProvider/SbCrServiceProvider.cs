using DryIoc;
using SbCr.Abstraction;

namespace SbCr.ServiceProvider
{
    public class SbCrServiceProvider : IServiceCollection
    {
        private readonly IIocContainer _container;
        public SbCrServiceProvider()
        {
            // TODO: Ioc-Container
            var container = new Container();

            _container = new SbCrIocContainer(container);
            container.Register<IIocContainer, SbCrIocContainer>(Reuse.Singleton);


            // Registering Services 
            RegisterServices();
        }

        private void RegisterServices()
        {

        }

        public IIocContainer GetContainer()
        {
            return _container;
        }
    }
}
