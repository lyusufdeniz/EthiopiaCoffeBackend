using System.Net;
using System.Text.Json.Serialization;

namespace EthiopiaCoffe.Repository.DTOs
{
   public struct NoContent
    {

    }
    public record ResponseDTO<T>
    {
        public T? Data { get; init; }
        public List<string>? Errors { get; init; }
        [JsonIgnore] public bool IsSucces { get; init; }
        [JsonIgnore] public HttpStatusCode StatusCode { get; init; }

        public static ResponseDTO<T> Succes(T Data, HttpStatusCode statusCode = HttpStatusCode.OK)
        {
            return new ResponseDTO<T> { Data = Data, StatusCode = statusCode, IsSucces = true };

        }
        public static ResponseDTO<T> Succes(HttpStatusCode statusCode)
        {
            return new ResponseDTO<T> { StatusCode = statusCode, IsSucces = true };

        }
        public static ResponseDTO<T> Fail(List<string> errors, HttpStatusCode statusCode = HttpStatusCode.BadRequest)
        {
            return new ResponseDTO<T> { Errors = errors, StatusCode = statusCode, IsSucces = false };

        }
        public static ResponseDTO<T> Fail(string error, HttpStatusCode statusCode = HttpStatusCode.BadRequest)
        {
            return new ResponseDTO<T> { Errors = new List<string> { error }, StatusCode = statusCode, IsSucces = false };

        }
    }

}