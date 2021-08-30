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

    }
}


/*
 dotnet new mvc --output "src" --name "Application"


dotnet aspnet-codegenerator controller --controllerName commentsController -outDir Controllers --model Comment --dataContext MainDbContext -udl -scripts
dotnet aspnet-codegenerator controller --controllerName commentsController -outDir Controllers --model Comment --dataContext MainDbContext -udl -scripts --force


dotnet ef migrations add <migration name>
dotnet ef migrations list
dotnet ef database update


 
 
 */
