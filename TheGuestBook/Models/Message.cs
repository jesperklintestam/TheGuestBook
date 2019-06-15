using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Razor;

namespace TheGuestBook.Models
{
    public class Message
    {
        public Message()
        {
            CreationDate = DateTime.Now;
        }
        public int Id { get; set; }
        public string Title { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Created")]
        public DateTime CreationDate { get; set; }
        public string Author { get; set; }
        public int AuthorId { get; set; }
        [Display(Name = "Likes")]
        public int NumberOfLikes { get; set; }
        [Display(Name = "Message")]
        public string MessageBody { get; set; }
    }
}
