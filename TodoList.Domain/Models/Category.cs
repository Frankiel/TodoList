using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TodoList.Domain.Models
{
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Field is required")]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Field is required")]
        public string Color { get; set; }

        public ICollection<Note> Notes { get; set; }
    }
}
