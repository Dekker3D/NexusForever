using NexusForever.Network.Message;
using NexusForever.Network.World.Message.Model;
using System;

namespace NexusForever.WorldServer.Network.Message.Handler.Contact
{
    public class ClientFriendInviteResponseHandler : IMessageHandler<IWorldSession, ClientFriendInviteResponse>
    {
        public void HandleMessage(IWorldSession session, ClientFriendInviteResponse packet)
        {
            throw new NotImplementedException();
        }
    }
}
