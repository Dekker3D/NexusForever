using NexusForever.Network.Message;
using NexusForever.Network.World.Message.Model;
using System;

namespace NexusForever.WorldServer.Network.Message.Handler.Contact
{
    internal class ClientFriendAccountPersonalStatusChangeHandler : IMessageHandler<IWorldSession, ClientFriendAccountPersonalStatusChange>
    {
        public void HandleMessage(IWorldSession session, ClientFriendAccountPersonalStatusChange packet)
        {
            throw new NotImplementedException();
        }
    }
}
