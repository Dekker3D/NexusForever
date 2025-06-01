using NexusForever.Network.Message;
using NexusForever.Network.World.Message.Model;

namespace NexusForever.WorldServer.Network.Message.Handler.Contact
{
    public class ClientFriendAccountUpgradeFromFriendHandler : IMessageHandler<IWorldSession, ClientFriendAccountUpgradeFromFriend>
    {
        public void HandleMessage(IWorldSession session, ClientFriendAccountUpgradeFromFriend packet)
        {
            throw new System.NotImplementedException();
        }
    }
}
