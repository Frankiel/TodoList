using System;
using System.Collections.Generic;
using System.Text;
using TodoList.Extensibility.Dto;

namespace TodoList.Extensibility.Validators
{
    public interface ICategoryValidator
    {
        bool ValidateExistence(int id);

        bool ValidateInput(CategoryAddUpdateDto note);
    }
}
