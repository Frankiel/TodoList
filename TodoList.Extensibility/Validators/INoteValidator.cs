using System;
using System.Collections.Generic;
using System.Text;
using TodoList.Extensibility.Dto;

namespace TodoList.Extensibility.Validators
{
    public interface INoteValidator
    {
        bool ValidateExistence(int id);

        bool ValidateAdd(NoteCreateDto note);
    }
}
