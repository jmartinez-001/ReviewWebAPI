using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReviewWebAPI.Models
{
    public class ReviewDTO
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string AuthorName { get; set; }
    }
}