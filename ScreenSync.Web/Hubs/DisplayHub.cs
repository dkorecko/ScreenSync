namespace ScreenSync.Web.Hubs;

public class DisplayHub : Hub
{
    public async Task Update()
    {
        await Clients.All.SendAsync(Constants.HubRoutes.UPDATE);
    }
}
