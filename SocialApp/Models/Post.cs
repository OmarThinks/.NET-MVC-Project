using System;
using SocialApp.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace SocialApp.Models
{
    public class Post
    {
        public int ID { get; set; }
        public string Content { get; set; }

    	[ForeignKey("ApplicationUser")]
        public int AuthorId { get; set; }
    	public ApplicationUser Author { get; set; }
    }
}


/*
dotnet-aspnet-codegenerator controller -name PostsController -m Post --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries -dc SocialApp.Data.ApplicationDbContext
*/