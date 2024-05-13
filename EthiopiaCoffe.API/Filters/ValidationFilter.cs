using EthiopiaCoffe.Repository.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace EthiopiaCoffe.API.Filters
{
    public class ValidationFilter :Attribute, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
       
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {

                var errors = context.ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage).ToList();
                context.Result = new BadRequestObjectResult(ResponseDTO<NoContent>.Fail(errors));

            }
        }
    }
}
