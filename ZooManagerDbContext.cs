using Microsoft.EntityFrameworkCore;
using ZooManager.Models.Database;

namespace ZooManager;
// namespace TodoApi.Models;

public class ZooManagerDbContext : DbContext
{
    public ZooManagerDbContext(DbContextOptions<ZooManagerDbContext> options)
        : base(options)
    {
    }

    public DbSet<Animal> Animals { get; set; } = null!;
    public DbSet<AnimalType> AnimalTypes { get; set; }
}