using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TodoList.Domain.Models;
using TodoList.Extensibility.Dto;
using TodoList.Extensibility.Providers;
using TodoList.Extensibility.Repository;

namespace TodoList.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly INoteProvider noteProvider;

        public ValuesController(INoteProvider noteProvider)
        {
            this.noteProvider = noteProvider;
        }
        // GET api/values
        [HttpGet]
        public IEnumerable<NoteDto> Get()
        {
            return noteProvider.GetAllNotes();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public NoteDto Get(int id)
        {
            return noteProvider.GetNote(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
