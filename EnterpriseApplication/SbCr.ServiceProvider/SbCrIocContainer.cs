using DryIoc;
using SbCr.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace SbCr.ServiceProvider
{
    internal class SbCrIocContainer : IIocContainer
    {
        private readonly IContainer _container;
        public SbCrIocContainer(IContainer container)
        {
            _container = container;
        }

        public void Register<TInterface, TImplementation>(string key = null) where TImplementation : TInterface
        {
            _container.Register<TInterface, TImplementation>(serviceKey: key);
        }

        public void RegisterSingelton<TInterface, TImplementation>(string key = null) where TImplementation : TInterface
        {
            _container.Register<TInterface, TImplementation>(serviceKey: key, reuse: Reuse.Singleton);
        }

        public TInterface Resolve<TInterface>(string key = null)
        {
            return _container.Resolve<TInterface>(serviceKey: key);
        }
    }
}
