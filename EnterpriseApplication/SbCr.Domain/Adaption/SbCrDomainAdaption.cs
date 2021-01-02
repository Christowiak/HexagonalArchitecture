using SbCr.Abstraction;
using System;

namespace SbCr.Domain.Adaption
{
    public class SbCrDomainAdaption : IDomainAdaption
    {
        private readonly IIocContainer _container;
        public SbCrDomainAdaption(IIocContainer container)
        {
            _container = container;
        }

        public void Initialize(object repositoryData)
        {
            Console.WriteLine("Domain Adaption Initialized");
        }
    }
}
