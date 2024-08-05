using FA.Client.Be.Repository.Entity;
using Microsoft.EntityFrameworkCore;

namespace FA.Client.Be.Repository;

public class FADbContext : DbContext
{
    public List<UserEntity> Users { get; set; }
    
    public FADbContext(DbContextOptions<FADbContext> options)
        : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<UserEntity>().HasKey(x => x.Id);
    }
}