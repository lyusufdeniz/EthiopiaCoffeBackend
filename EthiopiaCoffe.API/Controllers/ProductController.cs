using EthiopiaCoffe.Repository.DTOs.Product;
using EthiopiaCoffe.Repository.Services;
using Microsoft.AspNetCore.Mvc;

namespace EthiopiaCoffe.API.Controllers
{

    public class ProductController(IProductService _productService) : CustomBaseController
    {
     

        [HttpGet]
        public async Task<IActionResult> Get() => CreateActionResult(await _productService.AllAsync());

        [HttpGet("[action]")]
        public async Task<IActionResult> GetWithCategory() => CreateActionResult(await _productService.ProductsWithCategory());

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id) => CreateActionResult(await _productService.GetById(id));

        [HttpPost]
        public async Task<IActionResult> Add(ProductAddDTO productDTO) => CreateActionResult(await _productService.AddAsync(productDTO));
        [HttpPut]
        public async Task<IActionResult> Update(ProductUpdateDTO productDTO) => CreateActionResult(await _productService.UpdateAsync(productDTO));
        [HttpDelete]
        public async Task<IActionResult> Delete(ProductDTO productDTO) => CreateActionResult(await _productService.DeleteAsync(productDTO));
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id) => CreateActionResult(await _productService.DeleteAsync(id));


    }
}