using Microsoft.EntityFrameworkCore;
using w8d4_ZooManager.Models.Database;

namespace w8d4_ZooManager;
// namespace TodoApi.Models;

public class ZooManagerDbContext : DbContext
{
    public ZooManagerDbContext(DbContextOptions<ZooManagerDbContext> options)
        : base(options)
    {
    }

    public DbSet<Animal> Animals { get; set; } = null!;
}