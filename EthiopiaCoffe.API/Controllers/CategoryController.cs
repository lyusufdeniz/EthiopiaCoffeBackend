using EthiopiaCoffe.Repository.DTOs.Category;
using EthiopiaCoffe.Repository.DTOs.Product;
using EthiopiaCoffe.Repository.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EthiopiaCoffe.API.Controllers
{

    public class CategoryController : CustomBaseController
    {
        ICategoryService _categoryService;


        public CategoryController(ICategoryService categoryService) => _categoryService = categoryService;


        [HttpGet]
        public IActionResult Get() => CreateActionResult(_categoryService.GetAll());
        [HttpGet("[action]")]
        public IActionResult CategoryWithProducts() => CreateActionResult(_categoryService.CategoryWithProducts());
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id) => CreateActionResult(await _categoryService.GetByIdAsync(id));

        [HttpPost]
        public async Task<IActionResult> Add(CategoryAddDTO entity)=> CreateActionResult(await _categoryService.AddAsync(entity));
     

        [HttpPut]
        public IActionResult Update(CategoryUpdateDTO entity) => CreateActionResult(_categoryService.Update(entity));
        [HttpDelete]
        public IActionResult Delete(CategoryDTO entity) => CreateActionResult(_categoryService.Delete(entity));
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id) => CreateActionResult(await _categoryService.Delete(id));

    }
}
