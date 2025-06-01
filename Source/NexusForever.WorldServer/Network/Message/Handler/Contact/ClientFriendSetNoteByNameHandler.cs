using NexusForever.Network.Message;
using NexusForever.Network.World.Message.Model;
using System;

namespace NexusForever.WorldServer.Network.Message.Handler.Contact
{
    public class ClientFriendSetNoteByNameHandler : IMessageHandler<IWorldSession, ClientFriendSetNoteByName>
    {
        public void HandleMessage(IWorldSession session, ClientFriendSetNoteByName packet)
        {
            throw new NotImplementedException();
        }
    }
}
