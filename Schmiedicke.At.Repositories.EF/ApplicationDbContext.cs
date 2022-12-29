using Microsoft.EntityFrameworkCore;
using Schmiedicke.At.Models;

namespace Schmiedicke.At.Repositories.EF;

public class ApplicationDbContext : DbContext
{
    public DbSet<Link> Links => Set<Link>();
}
