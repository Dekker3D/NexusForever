using NexusForever.Network.Message;
using NexusForever.Network.World.Message.Model;
using System;

namespace NexusForever.WorldServer.Network.Message.Handler.Contact
{
    public class ClientFriendAccountRemoveHandler : IMessageHandler<IWorldSession, ClientFriendAccountRemove>
    {
        public void HandleMessage(IWorldSession session, ClientFriendAccountRemove packet)
        {
            throw new NotImplementedException();
        }
    }
}
