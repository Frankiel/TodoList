using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TodoList.Domain.Models
{
    public class Note
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Field is required")]
        [MaxLength(300)]
        public string Text { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }
}
