namespace Esstra.Hit.Client.Operations
{
    using System.Runtime.Serialization;

    [Serializable]
    internal class ColumnsMissingException : Exception
    {
        public ColumnsMissingException()
        {
        }

        public ColumnsMissingException(string? message) : base(message)
        {
        }

        public ColumnsMissingException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected ColumnsMissingException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}