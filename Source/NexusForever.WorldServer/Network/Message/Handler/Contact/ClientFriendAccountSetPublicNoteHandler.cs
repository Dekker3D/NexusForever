using NexusForever.Network.Message;
using NexusForever.Network.World.Message.Model;
using System;

namespace NexusForever.WorldServer.Network.Message.Handler.Contact
{
    public class ClientFriendAccountSetPublicNoteHandler : IMessageHandler<IWorldSession, ClientFriendAccountSetPublicNote>
    {
        public void HandleMessage(IWorldSession session, ClientFriendAccountSetPublicNote packet)
        {
            throw new NotImplementedException();
        }
    }
}
