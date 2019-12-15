using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TodoList.Extensibility.Dto;
using TodoList.Extensibility.Services;

namespace TodoList.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotesController : ControllerBase
    {
        private readonly INoteService _noteService;

        public NotesController(INoteService noteService)
        {
            this._noteService = noteService;
        }
        // GET api/notes
        [HttpGet]
        public IEnumerable<NoteDto> Get()
        {
            return _noteService.GetAllNotes();
        }

        // GET api/notes/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return _noteService.GetNote(id);
        }

        // POST api/notes
        [HttpPost]
        public IActionResult Post([FromBody] NoteCreateDto note)
        {
            return _noteService.Add(note);
        }

        // PUT api/notes/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] NoteCreateDto note)
        {
            return _noteService.Update(id, note);
        }

        // DELETE api/notes/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return _noteService.Delete(id);
        }
    }
}
