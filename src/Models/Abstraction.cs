using System;
using Microsoft.AspNetCore.Identity;
using Application.Models;
using System.Collections.Generic;
using System.Text.Json;

namespace Application.Models
{
    public class Abstraction
    {
        public class HasAuthor 
        {
            public string AuthorId { get; set; }
            public ApplicationUser Author { get; set; }
        }
    }
    /*            Console.WriteLine(JsonSerializer.Serialize(post));
*/
}
