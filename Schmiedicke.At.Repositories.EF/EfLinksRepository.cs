using Microsoft.EntityFrameworkCore;
using Schmiedicke.At.Models;

namespace Schmiedicke.At.Repositories.EF;

public class EfLinksRepository : ILinksRepositories
{
    private readonly ApplicationDbContext _context;

    public EfLinksRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<LinkListItem>> GetAllForUserAsync(string username)
    {
        return await _context.LinkListItems
                             .Where(x => x.Username == username || x.Username == null)
                             .ToListAsync();
    }
}