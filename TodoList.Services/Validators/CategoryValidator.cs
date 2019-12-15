using System;
using System.Collections.Generic;
using System.Text;
using TodoList.Extensibility.Dto;
using TodoList.Extensibility.Repository;
using TodoList.Extensibility.Validators;

namespace TodoList.Services.Validators
{
    public class CategoryValidator : ICategoryValidator
    {
        private readonly ICategoryRepository categoryRepository;

        public CategoryValidator(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        public bool ValidateExistence(int id)
        {
            return categoryRepository.Get(id) != null;
        }

        public bool ValidateInput(CategoryAddUpdateDto note)
        {
            throw new NotImplementedException();
        }
    }
}
