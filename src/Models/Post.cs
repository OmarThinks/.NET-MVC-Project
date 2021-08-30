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



 
 */

