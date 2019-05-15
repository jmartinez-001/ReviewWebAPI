using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ReviewWebAPI.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Author")]
        [Display(Name = "Author")]
        public int AuthorId { get; set; }

        public Author Author { get; set; }

        [Display(Name = "Content")]
        public string Content { get; set; }

        [Display(Name = "Comment Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime Date { get; set; }

        public ICollection<Comment> Comments { get; set; }
    }
}