using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class TravelersDbContext: DbContext
    {
        public TravelersDbContext(DbContextOptions<TravelersDbContext> options): base(options){}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {}
        
        public virtual DbSet<ArticleEntity> Articles { get; set; }
    }
}