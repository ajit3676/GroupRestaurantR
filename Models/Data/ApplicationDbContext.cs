using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HamroLibrary.Models.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<LibraryAccount> LibraryAccounts { get; set; }
    }
}