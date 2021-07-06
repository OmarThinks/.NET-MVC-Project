using System;

namespace SocialApp.Models
{
    public class Comment
    {
        public int ID { get; set; }
        public string Content { get; set; }
    }
}


/*
dotnet-aspnet-codegenerator controller -name CommentsController -m Comment --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries -dc SocialApp.Data.ApplicationDbContext
*/