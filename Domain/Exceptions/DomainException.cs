namespace Domain.Exceptions
{
    internal class DomainException : Exception
    {
        public DomainException(string message)
            : base($"Domain exception: ({message}).")
        {
        }
    }
}
