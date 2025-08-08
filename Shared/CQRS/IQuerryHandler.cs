namespace Shared.CQRS
{
    public interface IQueryHandler<in TQuerry, TResponse>
        : IRequestHandler<TQuerry, TResponse>
        where TQuerry : IQuerry<TResponse>
        where TResponse : notnull
    {
    }
}
