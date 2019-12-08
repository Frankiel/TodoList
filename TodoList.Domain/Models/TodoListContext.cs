using Microsoft.EntityFrameworkCore;

namespace TodoList.Domain.Models
{
    public sealed class TodoListContext : DbContext
    {
        public DbSet<Note> Notes { get; set; }
        public DbSet<Category> Categories { get; set; }

        public TodoListContext(DbContextOptions<TodoListContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=TodoListDB;Trusted_Connection=True;");
        }
    }
}
