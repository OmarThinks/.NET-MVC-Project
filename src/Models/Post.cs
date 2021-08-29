using System;
using System.ComponentModel.DataAnnotations;

namespace SocialApp.Models
{
    public class Post
    {
        public int Id { get; set; }
        //public string Con { get; set; }
    }
}


/*

 dotnet new webapp --output "src" --name "SocialApp" --auth Individual


dotnet aspnet-codegenerator controller --controllerName postsController -outDir Controllers --model Post --dataContext SocialApp.Data.ApplicationDbContext -udl -scripts

*/