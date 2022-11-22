using Microsoft.EntityFrameworkCore;
using WorldCup.Models;

namespace WorldCup.DAL;

public class WorldCupContext : DbContext
{
    public WorldCupContext(DbContextOptions<WorldCupContext> options)
        : base(options)
    {
        
    }

    public DbSet<Pais> Paises { get; set; }
}