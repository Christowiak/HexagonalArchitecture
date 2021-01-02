using SbCr.Abstraction;
using SbCr.Framework;
using SbCr.ServiceProvider;
using System;

namespace SbCr.Support.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var framework = new SbCrFramework(new SbCrServiceProvider());
            framework.Initialize();


            var domainAdaption = framework.GetComponent<IDomainAdaption>();

            System.Console.ReadLine();
        }
    }
}
