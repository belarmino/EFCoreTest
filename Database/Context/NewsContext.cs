using Database.ModelConfig;
using Database.Models;
using Microsoft.EntityFrameworkCore;
namespace Database.Context
{
    public class NewsContext:DbContext {
        public DbSet<Category> Category { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder options){
            //Connect with database
            options.UseSqlite($"Data Source=newsdb.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            //Apply Model configuration
            modelBuilder.ApplyConfiguration(new CategoryConfig());
        }
    }

} 