using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesMovie.Models
{
    public class Post
    {
        public int ID { get; set; }
        public string Content { get; set; }
    }
}