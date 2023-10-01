using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoAppEntityLayer.Entities
{
    [Table("todo")]
    public class ToDo
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Boş geçilemez!")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "İsim min 2 mak 50 karakter olmalı")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Boş geçilemez!")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "İsim min 2 mak 50 karakter olmalı")]
        public string Description { get; set; }
        public DateTime? CompletionDate { get; set; }
        public bool IsActive { get; set; }


    }
}
