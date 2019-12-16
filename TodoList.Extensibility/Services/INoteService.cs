using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TodoList.Extensibility.Dto;

namespace TodoList.Extensibility.Services
{
    public interface INoteService
    {
        IEnumerable<NoteDto> GetAllNotes();

        IActionResult GetNote(int id);

        IActionResult Add(NoteCreateUpdateDto note);

        IActionResult Delete(int id);

        IActionResult Update(int id, NoteCreateUpdateDto note);
    }
}
