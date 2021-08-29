using System;
using System.ComponentModel.DataAnnotations;

namespace SocialApp.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Content { get; set; }
    }
}


/*

dotnet new mvc --output "src" --name "SocialApp" --auth Individual



dotnet aspnet-codegenerator controller --controllerName commentsController -outDir Controllers --model Comment --dataContext SocialApp.Data.ApplicationDbContext -udl -scripts


dotnet ef migrations add CreatedCommentModel
dotnet ef migrations list
dotnet ef database update

*/