using Schmiedicke.At.Models;

namespace Schmiedicke.At.Repositories;

public interface ILinksRepositories
{
    Task<IEnumerable<LinkListItem>> GetAllForUserAsync(string username);
}