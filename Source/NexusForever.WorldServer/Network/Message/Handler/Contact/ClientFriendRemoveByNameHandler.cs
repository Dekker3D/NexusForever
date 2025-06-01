using NexusForever.Network.Message;
using NexusForever.Network.World.Message.Model;
using System;

namespace NexusForever.WorldServer.Network.Message.Handler.Contact
{
    public class ClientFriendRemoveByNameHandler : IMessageHandler<IWorldSession, ClientFriendRemoveByName>
    {
        public void HandleMessage(IWorldSession session, ClientFriendRemoveByName packet)
        {
            throw new NotImplementedException();
        }
    }
}
