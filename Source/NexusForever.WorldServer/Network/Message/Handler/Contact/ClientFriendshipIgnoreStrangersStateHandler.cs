using NexusForever.Network.Message;
using NexusForever.Network.World.Message.Model;
using System;

namespace NexusForever.WorldServer.Network.Message.Handler.Contact
{
    public class ClientFriendshipIgnoreStrangersStateHandler : IMessageHandler<IWorldSession, ClientFriendshipIgnoreStrangersState>
    {
        public void HandleMessage(IWorldSession session, ClientFriendshipIgnoreStrangersState packet)
        {
            throw new NotImplementedException();
        }
    }
}