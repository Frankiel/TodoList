using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace TodoList.Domain.Models
{
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryId { set; get; }

        [Required(ErrorMessage = "Field is required")]
        [MaxLength(100)]
        public string Name { set; get; }

        [Required(ErrorMessage = "Field is required")]
        public string Color { set; get; }
    }
}
