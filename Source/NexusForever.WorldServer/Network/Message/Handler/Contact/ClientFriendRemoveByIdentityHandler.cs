using NexusForever.Network.Message;
using NexusForever.Network.World.Message.Model;
using System;

namespace NexusForever.WorldServer.Network.Message.Handler.Contact
{
    public class ClientFriendRemoveByIdentityHandler : IMessageHandler<IWorldSession, ClientFriendRemoveByIdentity>
    {
        public void HandleMessage(IWorldSession session, ClientFriendRemoveByIdentity packet)
        {
            throw new NotImplementedException();
        }
    }
}
