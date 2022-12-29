using Schmiedicke.At.Models;

namespace Schmiedicke.At.Services;

public class LinksService : ILinksService
{
    static readonly IEnumerable<Link> _defaultLinks = new Link[]
    {
        new("Outlook", "https://outlook.office365.com/mail/", "./img/outlook.svg"),
        new("Azure", "https://portal.azure.com/", "./img/azure.png"),
    };
        
    public Task<IEnumerable<Link>> GetAllForUser(string username)
    {
        return Task.FromResult(_defaultLinks);
    }
}