using System;
using Microsoft.AspNetCore.Identity;
using Application.Models;
using System.Collections.Generic;
using System.Text.Json;
using System.Security.Claims;


namespace Application.Models
{
    public class ApplicationUser : IdentityUser
    {
        public List<Post> Posts { get; set; }
        public List<Comment> Comments { get; set; }

        public static void AuthorHandler(Abstraction.HasAuthor inputObject, string AuthorId )
        {
            //Console.WriteLine(JsonSerializer.Serialize(inputObject));
            inputObject.AuthorId = AuthorId;
            inputObject.Author = null;
            //Console.WriteLine(JsonSerializer.Serialize(inputObject));
            //return inputObject;
        }
    }
    /*            Console.WriteLine(JsonSerializer.Serialize(post));
*/
}
