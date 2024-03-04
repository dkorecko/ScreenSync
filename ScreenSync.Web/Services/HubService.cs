using Microsoft.AspNetCore.Components;

namespace ScreenSync.Web.Services;

public class HubService
{
    private readonly NavigationManager _navigationManager;

    public HubService(NavigationManager navigationManager)
    {
        _navigationManager = navigationManager;
    }

    public HubConnection MakeHubConnection(string hubName) =>
        new HubConnectionBuilder()
            .WithAutomaticReconnect()
            .WithUrl(_navigationManager.ToAbsoluteUri(hubName))
            .Build();
}
