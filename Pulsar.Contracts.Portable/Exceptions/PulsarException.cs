using System;

namespace Pulsar.Contracts.Portable.Exceptions
{
    public class PulsarException : Exception
    {
        public string ErrorCode { get; private set; }
        public string ErrorMessage { get; private set; }

        public PulsarException(string errorCode, string errorMessage)
            : base(errorCode + ": " + errorMessage)
        {
            ErrorCode = errorCode;
            ErrorMessage = errorMessage;
        }

        public PulsarException(string errorCode, string errorMessageFormat, params object[] parameters)
            : this(errorCode, String.Format(errorMessageFormat, parameters))
        { }

        public PulsarException(string message) :
            base(message.StartsWith("E_") ? message : "E_PUL.000: " + message)
        { }
    }
}