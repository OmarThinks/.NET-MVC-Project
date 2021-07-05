using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using RazorPagesMovie.Models;
using System.Linq;
using System.Collections.Generic;
//using Fluent.Infrastructure.FluentModel;

namespace RazorPagesMovie.Models
{
    public class Post
    {
        public int ID { get; set; }
        public string Content { get; set; }

    	public List<Comment> Comments { get; set; }
        /*
    	[Key]
        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual ApplicationUser User { get; set; }*/

    }
}


/*
dotnet-aspnet-codegenerator controller -name PostsController -m Post -dc SocialAppContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries
*/