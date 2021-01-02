namespace SbCr.Abstraction
{
    public interface IFramework
    {
        void Initialize();

        TInterface GetComponent<TInterface>();
    }
}
