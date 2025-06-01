using NexusForever.Network.Message;
using NexusForever.WorldServer.Network.Message.Model;
using System;

namespace NexusForever.WorldServer.Network.Message.Handler.Contact
{
    public class ClientFriendAccountAddByNameHandler : IMessageHandler<IWorldSession, ClientFriendAccountAddByName>
    {
        public void HandleMessage(IWorldSession session, ClientFriendAccountAddByName packet)
        {
            throw new NotImplementedException();
        }
    }
}
