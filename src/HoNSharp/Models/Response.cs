using System.Net;

namespace HoNSharp.Models
{
    public class Response<T>
    {
        public bool IsSuccess { get; internal set; }

        public HttpStatusCode StatusCode { get; internal set; }

        public string ErrorMessage { get; internal set; }

        public T Content { get; internal set; }
    }
}
