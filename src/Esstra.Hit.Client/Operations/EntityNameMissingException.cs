namespace Esstra.Hit.Client.Operations
{
    using System.Runtime.Serialization;

    [Serializable]
    internal class EntityNameMissingException : Exception
    {
        public EntityNameMissingException()
        {
        }

        public EntityNameMissingException(string? message) : base(message)
        {
        }

        public EntityNameMissingException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected EntityNameMissingException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}