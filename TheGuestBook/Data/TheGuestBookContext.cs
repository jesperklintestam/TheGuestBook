using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TheGuestBook.Models
{
    public class TheGuestBookContext : DbContext
    {
        public TheGuestBookContext (DbContextOptions<TheGuestBookContext> options)
            : base(options)
        {
        }

        public DbSet<TheGuestBook.Models.Message> Message { get; set; }
    }
}
