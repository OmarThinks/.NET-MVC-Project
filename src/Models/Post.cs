using System;
using System.ComponentModel.DataAnnotations;

namespace Application.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Content { get; set; }
    }
}


/*
 dotnet new mvc --output "src" --name "Application"


dotnet aspnet-codegenerator controller --controllerName postsController -outDir Controllers --model Post --dataContext MainDbContext -udl -scripts
dotnet aspnet-codegenerator controller --controllerName postsController -outDir Controllers --model Post --dataContext MainDbContext -udl -scripts --force

 
 */

