using System.Runtime.Serialization;

namespace XUnitPractice
{
    [Serializable]
    public class TankFullException : Exception
    {
        public TankFullException()
        {
        }

        public TankFullException(string? message) : base(message)
        {
        }

        public TankFullException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected TankFullException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}