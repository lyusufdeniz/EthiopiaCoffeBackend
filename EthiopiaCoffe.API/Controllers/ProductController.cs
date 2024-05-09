using EthiopiaCoffe.Repository.DTOs;
using EthiopiaCoffe.Repository.DTOs.Product;
using EthiopiaCoffe.Repository.Services;
using Microsoft.AspNetCore.Mvc;

namespace EthiopiaCoffe.API.Controllers
{

    public class ProductController : CustomBaseController
    {
        IProductService _productService;


        public ProductController(IProductService productService) => _productService = productService;


        [HttpGet]
        public IActionResult Get() => CreateActionResult(_productService.GetAll());
        [HttpGet("[action]")]
        public IActionResult GetWithCategory() => CreateActionResult(_productService.ProductsWithCategory());
        [HttpGet("{id}")]
        public async Task<IActionResult> Get( Guid id) => CreateActionResult(await _productService.GetByIdAsync(id));

        [HttpPost]
        public async Task<IActionResult> Add(ProductAddDTO productDTO) => CreateActionResult(await _productService.AddAsync(productDTO));
        [HttpPut]
        public  IActionResult Update(ProductUpdateDTO productDTO) => CreateActionResult( _productService.Update(productDTO));
        [HttpDelete]
        public IActionResult Delete(ProductDTO productDTO) => CreateActionResult(_productService.Delete(productDTO));
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id) => CreateActionResult(await _productService.Delete(id));
      

    }
}