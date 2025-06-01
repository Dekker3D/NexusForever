using NexusForever.Network.Message;
using NexusForever.Network.World.Message.Model;
using System;

namespace NexusForever.WorldServer.Network.Message.Handler.Contact
{
    public class ClientFriendSetNoteByIdentityHandler : IMessageHandler<IWorldSession, ClientFriendSetNoteByIdentity>
    {
        public void HandleMessage(IWorldSession session, ClientFriendSetNoteByIdentity packet)
        {
            throw new NotImplementedException();
        }
    }
}
