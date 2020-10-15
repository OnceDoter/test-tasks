using System.Runtime.InteropServices.ComTypes;
using Microsoft.EntityFrameworkCore;

namespace ef
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() //Connection string in appconfig.json
            : base()
        { Database.EnsureCreated(); }
        
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostComments> Comments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=ef.db");
        }
    }

}