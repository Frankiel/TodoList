using TodoList.Extensibility.Dto;

namespace TodoList.Extensibility.Validators
{
    public interface ICategoryValidator
    {
        bool ValidateExistence(int id);

        bool ValidateInput(CategoryCreateUpdateDto note);
    }
}
