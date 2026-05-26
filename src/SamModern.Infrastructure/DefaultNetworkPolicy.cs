using SamModern.Core;

namespace SamModern.Infrastructure;

public sealed class DefaultNetworkPolicy : INetworkPolicy
{
    private static readonly HashSet<string> AllowedHosts =
    [
        "store.steampowered.com",
        "steamcommunity.com",
        "cdn.steamstatic.com",
        "api.steampowered.com"
    ];

    public bool IsHostAllowed(string host)
    {
        if (string.IsNullOrWhiteSpace(host))
        {
            return false;
        }

        return AllowedHosts.Contains(host.Trim().ToLowerInvariant());
    }
}
