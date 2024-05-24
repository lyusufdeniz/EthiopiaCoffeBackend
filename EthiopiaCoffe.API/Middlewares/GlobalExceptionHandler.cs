using EthiopiaCoffe.Repository.DTOs;
using Microsoft.AspNetCore.Diagnostics;

namespace EthiopiaCoffe.API.Middlewares
{
    public class GlobalExceptionHandler:IExceptionHandler
    {
  //handle exception and write own response

        public async ValueTask<bool> TryHandleAsync(HttpContext httpContext, Exception exception, CancellationToken cancellationToken)
        {
            var responseModel = ResponseDTO<NoContent>.Fail(exception.Message,System.Net.HttpStatusCode.InternalServerError);
             await httpContext.Response.WriteAsJsonAsync(responseModel, cancellationToken: cancellationToken);
            return true;
        }
    }
}
