using System.Runtime.CompilerServices;
using System.Security.Claims;

namespace Schmiedicke.At.Models;

public static class Helpers
{
    public static IEnumerable<T> EmptyIfNull<T>(this IEnumerable<T>? enumerable) => enumerable ?? Enumerable.Empty<T>();

    public static string GetRealName(this IEnumerable<Claim> claims)
    {
        var enumerable = claims.ToList();
        var name = enumerable.FirstOrDefault(static x => x.Type is ClaimTypes.Name)?.Value;
        name ??= enumerable.FirstOrDefault(static x => x.Type is "name")?.Value;
        name ??= enumerable.FirstOrDefault(static x => x.Type is ClaimTypes.GivenName)?.Value;
        name ??= enumerable.FirstOrDefault(static x => x.Type is ClaimTypes.Surname)?.Value;
        name ??= enumerable.First(static x => x.Type is ClaimTypes.Email).Value;
        return name;
    }

    public static T NotNull<T>(this T? value, [CallerArgumentExpression(nameof(value))] string? argumentName = null)
        => value ?? throw new ArgumentNullException(argumentName);
}