namespace Shared.CQRS
{
    public interface IQuerry<out TResponse>
        : IRequest<TResponse>
    {
    }
}
