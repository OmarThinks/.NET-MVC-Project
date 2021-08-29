using System;
using System.ComponentModel.DataAnnotations;

namespace SocialApp.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Content { get; set; }
    }
}


/*

dotnet new webapp --output "src" --name "SocialApp" --auth Individual



dotnet aspnet-codegenerator controller --controllerName postsController -outDir Controllers --model Post --dataContext SocialApp.Data.ApplicationDbContext -udl -scripts


dotnet ef migrations add InitialCreate
dotnet ef migrations list
dotnet ef database update

*/