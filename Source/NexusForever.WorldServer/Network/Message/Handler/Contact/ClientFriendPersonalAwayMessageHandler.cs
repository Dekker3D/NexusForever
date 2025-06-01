using NexusForever.Network.Message;
using NexusForever.Network.World.Message.Model;
using System;

namespace NexusForever.WorldServer.Network.Message.Handler.Contact
{
    public class ClientFriendPersonalAwayMessageHandler : IMessageHandler<IWorldSession, ClientFriendPersonalAwayMessage>
    {
        public void HandleMessage(IWorldSession session, ClientFriendPersonalAwayMessage packet)
        {
            throw new NotImplementedException();
        }
    }
}
