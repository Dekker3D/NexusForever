using NexusForever.Network.Message;
using NexusForever.Network.World.Message.Model;
using System;

namespace NexusForever.WorldServer.Network.Message.Handler.Contact
{
    public class ClientFriendAccountInviteMarkSeenHandler : IMessageHandler<IWorldSession, ClientFriendAccountInviteMarkSeen>
    {
        public void HandleMessage(IWorldSession session, ClientFriendAccountInviteMarkSeen packet)
        {
            throw new NotImplementedException();
        }
    }
}
