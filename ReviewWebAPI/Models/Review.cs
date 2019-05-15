using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ReviewWebAPI.Models
{
    public class Review
    {
        [Key]
        public int Id{ get; set; }

        [ForeignKey("Author")]
        [Display(Name ="Author")]
        public int AuthorId { get; set; }
        
        public Author Author { get; set; }

        public string AuthorUserId { get; set; }

        public string SubjectUserId { get; set; }

        [Display(Name = "Job Type")]
        public string JobType { get; set; }

        [Display(Name ="Title")]
        public string Title { get; set; }

        [Display(Name ="Content")]
        public string Content { get; set; }

        [Display(Name ="Review Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime Date { get; set; }

        [Display(Name = "Rating")]
        public int Rating { get; set; }            
        
        [Display(Name = "Budget")]
        public string Budget { get; set; }

        [Display(Name = "Helpful")]
        public int Helpful { get; set; }

        public ICollection<Comment> Comments { get; set; }

    }
}