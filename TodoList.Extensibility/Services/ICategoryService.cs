using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TodoList.Extensibility.Dto;

namespace TodoList.Extensibility.Services
{
    public interface ICategoryService
    {
        IEnumerable<CategoryDto> GetAll();

        IActionResult Get(int id);

        IActionResult Add(CategoryCreateUpdateDto category);

        IActionResult Update(int id, CategoryCreateUpdateDto category);

        IActionResult Delete(int id);
    }
}
