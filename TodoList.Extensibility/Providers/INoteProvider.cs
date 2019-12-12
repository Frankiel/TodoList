using System;
using System.Collections.Generic;
using System.Text;
using TodoList.Extensibility.Dto;

namespace TodoList.Extensibility.Providers
{
    public interface INoteProvider
    {
        IEnumerable<NoteDto> GetAllNotes();

        NoteDto GetNote(int id);
    }
}
