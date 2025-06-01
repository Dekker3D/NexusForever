using NexusForever.Network.Message;
using NexusForever.Network.World.Message.Model;

namespace NexusForever.WorldServer.Network.Message.Handler.Contact
{
    public class ClientFriendAccountInviteResponseHandler : IMessageHandler<IWorldSession, ClientFriendAccountInviteResponse>
    {
        public void HandleMessage(IWorldSession session, ClientFriendAccountInviteResponse packet)
        {
            throw new System.NotImplementedException();
        }
    }
}
