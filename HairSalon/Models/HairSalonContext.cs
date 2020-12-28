using Microsoft.EntityFrameworkCore;
using HairSalon.Models;

namespace HairSalon.Models
{
    public class HairSalonContext : DbContext //class inherits from Entity, ensures all builtin DbContext functionality
    {
        public virtual DbSet<ParentClassName> ParentClassNames { get; set; } //allows lazy loading
        public DbSet<ChildClass> ChildClassNames { get; set; } //represents the db table and lets interaction

        public ProjectNameContext(DbContextOptions options) : base(options) { } //dependency injection, constructor inherits the behavior of its parent class constructor

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) //enables lazy-loading
        {
            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}