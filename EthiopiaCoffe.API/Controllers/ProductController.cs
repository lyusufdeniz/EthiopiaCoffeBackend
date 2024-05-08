using EthiopiaCoffe.Domain.Concrete.Entities;
using EthiopiaCoffe.Repository.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace EthiopiaCoffe.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IGenericRepository<Product> _repository;
        public ProductController(IGenericRepository<Product> generic)
        {
            _repository = generic;
        }

        [HttpGet]
      public  ActionResult Get()
        {
            return Ok(_repository.AllAsync());
        }
    }
}
