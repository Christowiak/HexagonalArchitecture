using SbCr.Abstraction;
using SbCr.Abstraction.Attributes;
using SbCr.Domain.Adaption;
using System;
using System.Reflection;

namespace SbCr.Framework
{
    public class SbCrFramework : IFramework
    {
        private readonly IServiceCollection _services;

        public SbCrFramework(IServiceCollection services)
        {
            _services = services;

            var container = _services.GetContainer();
            container.RegisterSingelton<IDomainAdaption, SbCrDomainAdaption>();
        }

        public TInterface GetComponent<TInterface>()
        {
            if (typeof(TInterface).GetCustomAttribute<ExportAttribute>() == null)
            {
                return default;
            }

            return _services.GetContainer().Resolve<TInterface>();
        }

        public void Initialize()
        {
            Console.WriteLine("Initialized");



            var domain = _services.GetContainer().Resolve<IDomainAdaption>();


            //
            domain.Initialize(null);
        }
    }
}
