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
        [DisplayFormat(DataFormatString = "{0:g}")]
        public DateTime CreationDate { get; set; }
        public string Author { get; set; }
        public string AuthorId { get; set; }
        [Display(Name = "Number Of Likes")]
        public int NumberOfLikes { get; set; }
        [Display(Name = "Message")]
        public string MessageBody { get; set; }
    }
}
