using System;
using SocialApp.Models;

namespace SocialApp.Models
{
    public class Post
    {
        public string Content { get; set; }

        //public int AuthorId { get; set; }
    	//public ApplicationUser Author { get; set; }
    }
}


/*
dotnet-aspnet-codegenerator controller -name PostsController -m Post --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries
*/