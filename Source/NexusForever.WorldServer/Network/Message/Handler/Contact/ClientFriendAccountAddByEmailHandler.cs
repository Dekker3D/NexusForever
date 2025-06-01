using NexusForever.Network.Message;
using NexusForever.Network.World.Message.Model;
using System;

namespace NexusForever.WorldServer.Network.Message.Handler.Contact
{
    public class ClientFriendAccountAddByEmailHandler : IMessageHandler<IWorldSession, ClientFriendAccountAddByEmail>
    {
        public void HandleMessage(IWorldSession session, ClientFriendAccountAddByEmail packet)
        {
            throw new NotImplementedException();
        }
    }
}
