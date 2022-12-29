using Schmiedicke.At.Models;

namespace Schmiedicke.At.Services;

public interface ILinksService
{
    Task<IEnumerable<Link>> GetAllForUser(string username);
}