using NexusForever.Network.Message;
using NexusForever.Network.World.Message.Model;
using System;

namespace NexusForever.WorldServer.Network.Message.Handler.Contact
{
    public class ClientFriendAccountAddByIdentityHandler : IMessageHandler<IWorldSession, ClientFriendAccountAddByIdentity>
    {
        public void HandleMessage(IWorldSession session, ClientFriendAccountAddByIdentity packet)
        {
            throw new NotImplementedException();
        }
    }
}
