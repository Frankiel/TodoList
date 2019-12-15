using System;
using System.Collections.Generic;
using System.Text;

namespace TodoList.Extensibility.Dto
{
    public class NoteCreateDto
    { 
        public string Text { set; get; }

        public int CategoryId { set; get; }
    }
}
