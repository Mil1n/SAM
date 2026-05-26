namespace SamModern.Core;

public interface INetworkPolicy
{
    bool IsHostAllowed(string host);
}
