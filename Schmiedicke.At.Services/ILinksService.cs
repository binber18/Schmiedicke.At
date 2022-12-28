using Schmiedicke.At.Models;

namespace Schmiedicke.At.Services;

public interface ILinksService
{
    Task<IEnumerable<LinkListItem>> GetAllForUser(string username);
}