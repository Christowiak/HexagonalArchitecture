namespace SbCr.Abstraction
{
   public interface IIocContainer
    {
        TInterface Resolve<TInterface>(string key = null);

        void Register<TInterface, TImplementation>(string key = null) where TImplementation : TInterface;

        void RegisterSingelton<TInterface, TImplementation>(string key = null) where TImplementation : TInterface;
    }
}
