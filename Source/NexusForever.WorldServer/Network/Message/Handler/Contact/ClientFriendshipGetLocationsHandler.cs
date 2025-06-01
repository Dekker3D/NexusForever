using NexusForever.Network.Message;
using NexusForever.Network.World.Message.Model;
using System;

namespace NexusForever.WorldServer.Network.Message.Handler.Contact
{
    internal class ClientFriendshipGetLocationsHandler : IMessageHandler<IWorldSession, ClientFriendshipGetLocations>
    {
        public void HandleMessage(IWorldSession session, ClientFriendshipGetLocations packet)
        {
            throw new NotImplementedException();
        }
    }
}
