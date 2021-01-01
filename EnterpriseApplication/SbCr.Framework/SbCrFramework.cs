using SbCr.Abstraction;
using System;

namespace SbCr.Framework
{
    public class SbCrFramework : IFramework
    {
        private readonly IServiceCollection _services;

        public SbCrFramework(IServiceCollection services)
        {
            _services = services;
        }

        public void Initialize()
        {
            Console.WriteLine("Initialized");
        }
    }
}
