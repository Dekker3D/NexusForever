using NexusForever.Network.Message;
using NexusForever.Network.World.Message.Model;

namespace NexusForever.WorldServer.Network.Message.Handler.Contact
{
    public class ClientFriendAccountSetPrivateDataHandler : IMessageHandler<IWorldSession, ClientFriendAccountSetPrivateData>
    {
        public void HandleMessage(IWorldSession session, ClientFriendAccountSetPrivateData packet)
        {
            throw new System.NotImplementedException();
        }
    }
}
