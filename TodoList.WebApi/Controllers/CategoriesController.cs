using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TodoList.Extensibility.Dto;
using TodoList.Extensibility.Services;

namespace TodoList.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            this._categoryService = categoryService;
        }

        // GET: api/Categories
        [HttpGet]
        public IEnumerable<CategoryDto> Get()
        {
            return _categoryService.GetAll();
        }

        // GET: api/Categories/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            return _categoryService.Get(id);
        }

        // POST: api/Categories
        [HttpPost]
        public IActionResult Post([FromBody] CategoryAddUpdateDto category)
        {
            return _categoryService.Add(category);
        }

        // PUT: api/Categories/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] CategoryAddUpdateDto category)
        {
            return _categoryService.Update(id, category);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return _categoryService.Delete(id);
        }
    }
}
