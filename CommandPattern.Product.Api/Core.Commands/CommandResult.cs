using System.Net;

namespace Core.Commands
{
    public class CommandResult<TValue>
    {
        public CommandResult(bool isSuccess, string message, TValue value, HttpStatusCode httpStatusCode)
        {
            Value = value;
            Message = message;
            IsSuccess = isSuccess;
            HttpStatusCode = httpStatusCode;
        }

        public TValue Value { get; }

        public string Message { get; }

        public bool IsSuccess { get; }

        public HttpStatusCode HttpStatusCode { get; }
    }
}
