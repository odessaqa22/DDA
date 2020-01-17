using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DDA.Models
{
    public class Publication
    {
        //public int Id { get; set; }
        //public int CategoryId { get; set; }
        //public int UserId { get; set; }
        //public int PublicationId { get; set; }
        //public int ImagePreviewId { get; set; }

        public int Id { get; set; }
        public Category CategoryPublication { get; set; }
        public User UserPublication { get; set; }
        public Article ArticlePublication { get; set; }
        public int ImagePreviewId { get; set; }

        public DateTime PublicationDate { get; set; }
        [Range(1, 10)]
        public int Rating { get; set; }
    }
}