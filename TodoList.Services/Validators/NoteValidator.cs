using TodoList.Extensibility.Dto;
using TodoList.Extensibility.Repository;
using TodoList.Extensibility.Validators;

namespace TodoList.Services.Validators
{
    public class NoteValidator : INoteValidator
    {
        private readonly INoteRepository noteRepository;
        private readonly ICategoryValidator categoryValidator;

        public NoteValidator(INoteRepository noteRepository, ICategoryValidator categoryValidator)
        {
            this.noteRepository = noteRepository;
            this.categoryValidator = categoryValidator;
        }

        public bool ValidateExistence(int id)
        {
            return noteRepository.Get(id) != null;
        }

        public bool ValidateAdd(NoteCreateUpdateDto note)
        {
            return (note.Text != null && note.CategoryId > 0 && categoryValidator.ValidateExistence(note.CategoryId));
        }
    }
}
