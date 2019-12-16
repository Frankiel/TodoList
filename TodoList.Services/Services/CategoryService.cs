using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TodoList.Extensibility.Dto;
using TodoList.Extensibility.Repository;
using TodoList.Extensibility.Services;
using TodoList.Extensibility.Validators;

namespace TodoList.Services.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository categoryRepository;
        private readonly ICategoryValidator categoryValidator;

        public CategoryService(ICategoryRepository categoryRepository, ICategoryValidator categoryValidator)
        {
            this.categoryRepository = categoryRepository;
            this.categoryValidator = categoryValidator;
        }

        public IEnumerable<CategoryDto> GetAll()
        {
            return categoryRepository.GellAll();
        }

        public IActionResult Get(int id)
        {
            if (!categoryValidator.ValidateExistence(id))
            {
                return new NotFoundResult();
            }

            return new OkObjectResult(categoryRepository.Get(id));
        }

        public IActionResult Add(CategoryCreateUpdateDto category)
        {
            if (!categoryValidator.ValidateInput(category))
            {
                return new BadRequestResult();
            }

            categoryRepository.Add(category);

            return new NoContentResult();
        }

        public IActionResult Update(int id, CategoryCreateUpdateDto category)
        {
            if (!categoryValidator.ValidateExistence(id) || !categoryValidator.ValidateInput(category))
            {
                return new BadRequestResult();
            }

            categoryRepository.Update(id, category);

            return new NoContentResult();
        }

        public IActionResult Delete(int id)
        {
            if (!categoryValidator.ValidateExistence(id))
            {
                return new NotFoundResult();
            }

            categoryRepository.Delete(id);
            
            return new NoContentResult();
        }
    }
}
