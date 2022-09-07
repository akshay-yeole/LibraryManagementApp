using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement.Models
{
    public class Book
    {
        [Column("BookId")]
        public int Id { get; set; }
        public string Name { get; set; }
        public int CopiesAvailable { get; set; }
        public string Author { get; set; }


        [ForeignKey(nameof(Category))]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
