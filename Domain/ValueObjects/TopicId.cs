namespace Domain.ValueObjects
{
    public record TopicId
    {
        public Guid Value { get; }

        private TopicId(Guid value)
        {
            Value = value;
        }

        public static TopicId Of(Guid value)
        {
            return new TopicId(value);
        }
    }
}
