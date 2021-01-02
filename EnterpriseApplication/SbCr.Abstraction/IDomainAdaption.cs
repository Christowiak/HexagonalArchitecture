using SbCr.Abstraction.Attributes;

namespace SbCr.Abstraction
{
    [Export]
    public interface IDomainAdaption
    {
        void Initialize(object repositoryData);
    }
}
