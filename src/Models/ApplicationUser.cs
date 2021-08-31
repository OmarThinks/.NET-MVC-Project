using System;
using Microsoft.AspNetCore.Identity;
using Application.Models;
using System.Collections.Generic;
using System.Text.Json;

namespace Application.Models
{
    public class ApplicationUser : IdentityUser
    {
        public List<Post> Posts { get; set; }
        public List<Comment> Comments { get; set; }

        public static void AuthorHandler(object inputObject)
        {
            Console.WriteLine(JsonSerializer.Serialize(inputObject));
            //inputObject.AuthorId = 12345;
        }
    }
    /*            Console.WriteLine(JsonSerializer.Serialize(post));
*/








}






