using System;
using System.ComponentModel.DataAnnotations;

namespace Application.Models
{
    public class Comment
    {
        public int CommentId { get; set; }

        public string Content { get; set; }

        public int PostId { get; set; }
        public Post Post { get; set; }


        public string AuthorId { get; set; }
        public ApplicationUser Author { get; set; }

    }
}


/*
 dotnet new mvc --output "src" --name "Application"



dotnet aspnet-codegenerator controller --controllerName commentsController -outDir Controllers --model Comment --dataContext Application.Data.ApplicationDbContext -udl -scripts
dotnet aspnet-codegenerator controller --controllerName commentsNewController -outDir Controllers --model Comment --dataContext Application.Data.ApplicationDbContext -udl -scripts






dotnet ef migrations add <migration name>
dotnet ef migrations list
dotnet ef database update


 
 
 */
