using NexusForever.Network.Message;
using NexusForever.Network.World.Message.Model;
using System;

namespace NexusForever.WorldServer.Network.Message.Handler.Contact
{
    public class ClientFriendInviteMarkedSeenHandler : IMessageHandler<IWorldSession, ClientFriendInviteMarkedSeen>
    {
        public void HandleMessage(IWorldSession session, ClientFriendInviteMarkedSeen packet)
        {
            throw new NotImplementedException();
        }
    }
}
