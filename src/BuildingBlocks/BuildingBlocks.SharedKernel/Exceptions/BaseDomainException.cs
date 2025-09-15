
namespace BuildingBlocks.SharedKernel.Exceptions
{
    public abstract class BaseDomainException : Exception
    {
        protected BaseDomainException(string message) : base(message) { }
    }
}
