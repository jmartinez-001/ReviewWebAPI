using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReviewWebAPI.Models
{
    public class ReviewDetailDTO
    {
        public int Id { get; set; }

        public string AuthorUserId { get; set; }

        public string SubjectUserId { get; set; }

        public string AuthorName { get; set; }

        public string Title { get; set; }

        public string JobType { get; set; }

        public string Content { get; set; }

        public DateTime Date { get; set; }

        public int Rating { get; set; }

        public string Budget { get; set; }

        public int Helpful { get; set; }

        public ICollection<Comment> Comments { get; set; }

    }
}