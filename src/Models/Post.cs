using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace SocialApp.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Content { get; set; }

    	public List<Comment> Comments { get; set; }        
    }
}


/*

dotnet new mvc --output "src" --name "SocialApp" --auth Individual



dotnet aspnet-codegenerator controller --controllerName postsController -outDir Controllers --model Post --dataContext SocialApp.Data.ApplicationDbContext -udl -scripts
dotnet aspnet-codegenerator controller --controllerName postsController -outDir Controllers --model Post --dataContext SocialApp.Data.ApplicationDbContext -udl -scripts -f


dotnet ef migrations add InitialCreate
dotnet ef migrations list
dotnet ef database update

*/