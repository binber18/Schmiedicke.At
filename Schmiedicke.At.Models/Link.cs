namespace Schmiedicke.At.Models;

public record Link(string Text, string Url, string Image)
{
    public List<string> Users { get; set; } = new List<string>();
}
