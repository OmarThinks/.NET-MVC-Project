using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
//using System.Web.DynamicData;
using System.Globalization;


namespace Application.Models
{
    public class Post// : Abstraction.HasAuthor
    {
        public int PostId { get; set; }
        
        [Required()]
        [MinLength(2)]
        [MaxLength(100)]
        public string Content { get; set; }

        public List<Comment> Comments { get; set; }

        [Editable(false)]
        public string AuthorId { get; set; }
        public ApplicationUser Author { get; set; }

    }
}


/*
 dotnet new mvc --output "src" --name "Application"


dotnet aspnet-codegenerator controller --controllerName postsController -outDir Controllers --model Post --dataContext Application.Data.ApplicationDbContext -udl -scripts
dotnet aspnet-codegenerator controller --controllerName postsNewController -outDir Controllers --model Post --dataContext Application.Data.ApplicationDbContext -udl -scripts --force

 
 */

