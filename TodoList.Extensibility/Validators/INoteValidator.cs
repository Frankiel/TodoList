using TodoList.Extensibility.Dto;

namespace TodoList.Extensibility.Validators
{
    public interface INoteValidator
    {
        bool ValidateExistence(int id);

        bool ValidateAdd(NoteCreateUpdateDto note);
    }
}
