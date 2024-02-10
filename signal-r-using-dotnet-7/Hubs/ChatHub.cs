using Microsoft.AspNetCore.SignalR;

namespace signal_r_using_dotnet_7.Hubs
{
    public class ChatHub :  Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
