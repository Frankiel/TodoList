using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using TodoList.Extensibility.Dto;

namespace TodoList.Extensibility.Services
{
    public interface ICategoryService
    {
        IEnumerable<CategoryDto> GetAll();

        IActionResult Get(int id);

        IActionResult Add(CategoryAddUpdateDto category);

        IActionResult Update(int id, CategoryAddUpdateDto category);

        IActionResult Delete(int id);
    }
}
