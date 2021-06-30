using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WebAPI.Models.Enums;

namespace WebAPI.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Name { get; set; }

        [Required]
        public Genre Genre { get; set; }

        public double Price { get; set; }

        public int Page { get; set; }

        [Required]
        public DateTime PublishedOn { get; set; }

        public ICollection<AuthorBook> AuthorsBooks { get; set; } = new List<AuthorBook>();
    }
}
