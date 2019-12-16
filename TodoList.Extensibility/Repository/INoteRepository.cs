using System.Collections.Generic;
using TodoList.Extensibility.Dto;

namespace TodoList.Extensibility.Repository
{
    public interface INoteRepository
    {
        IEnumerable<NoteDto> GetAll();

        NoteDto Get(int id);

        void Add(NoteCreateUpdateDto note);

        void Delete(int id);

        void Update(int id, NoteCreateUpdateDto note);
    }
}
