using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace Shop.WebApi.Hubs
{
    public class ChatHub: Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceivedMessage",user, message);
        }

        public override async Task OnConnectedAsync()
        {
            var context = Context.GetHttpContext();
            var requestPath = context.Request.Path.Value;
            //return base.OnConnectedAsync();
        }
    }
}
