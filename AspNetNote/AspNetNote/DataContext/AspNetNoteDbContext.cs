using System;
using AspNetNote.Models;
using Microsoft.EntityFrameworkCore;

namespace AspNetNote.DataContext
{
    public class AspNetNoteDbContext : DbContext
    {
        public AspNetNoteDbContext()
        {
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Note> Notes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseApplicationServiceProvider(@"Server=localhost;Database=aspnetNoteDb;User Id=sa;Password=1q2w3e4r;");
        }
    }
}
