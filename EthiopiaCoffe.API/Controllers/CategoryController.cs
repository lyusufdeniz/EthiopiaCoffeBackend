using EthiopiaCoffe.Repository.DTOs.Category;
using EthiopiaCoffe.Repository.Services;
using Microsoft.AspNetCore.Mvc;

namespace EthiopiaCoffe.API.Controllers
{

    public class CategoryController(ICategoryService categoryService) : CustomBaseController
    {
        


        //public CategoryController(ICategoryService categoryService) => _categoryService = categoryService;


        [HttpGet]
        public async Task<IActionResult> Get() => CreateActionResult(await categoryService.AllAsync());

        [HttpGet("[action]")]
        public async Task<IActionResult> CategoryWithProducts() => CreateActionResult(await categoryService.CategoryWithProductsAsync());

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id) => CreateActionResult(await categoryService.GetById(id));

        [HttpPost]
        public async Task<IActionResult> Add(CategoryAddDTO entity)=> CreateActionResult(await categoryService.AddAsync(entity));

        [HttpPut]
        public async Task<IActionResult> Update(CategoryUpdateDTO entity) => CreateActionResult(await categoryService.UpdateAsync(entity));
        [HttpDelete]
        public async Task<IActionResult> Delete(CategoryDTO entity) => CreateActionResult(await categoryService.DeleteAsync(entity));
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id) => CreateActionResult(await categoryService.DeleteAsync(id));

    }
}
