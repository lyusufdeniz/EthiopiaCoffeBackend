using EthiopiaCoffe.API.Filters;
using EthiopiaCoffe.Repository.DTOs;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace EthiopiaCoffe.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ValidationFilter]
    public class CustomBaseController : ControllerBase
    {



        public IActionResult CreateActionResult<T>(ResponseDTO<T> response)
        {
            if (response.StatusCode == HttpStatusCode.NoContent)
            {
                return new ObjectResult(null) { StatusCode = 204 };
            }
           
            return new ObjectResult(response) { StatusCode = (int)response.StatusCode };


        }
    }
}