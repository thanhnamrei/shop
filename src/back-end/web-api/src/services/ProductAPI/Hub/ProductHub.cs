using Microsoft.AspNetCore.SignalR;

namespace ProductAPI.Hub;
public class ProductHub : Microsoft.AspNetCore.SignalR.Hub
{

    public async Task SendProductReviewAdded()
    {
        await Clients.All.SendAsync("ProductReviewAdded");
    }
}
