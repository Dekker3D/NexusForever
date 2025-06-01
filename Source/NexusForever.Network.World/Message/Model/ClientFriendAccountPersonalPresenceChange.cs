using NexusForever.Game.Static.Social;
using NexusForever.Network.Message;

namespace NexusForever.Network.World.Message.Model
{
    [Message(GameMessageOpcode.ClientFriendAccountPersonalPresenceChange)]
    public class ClientFriendAccountPersonalStatusChange : IReadable
    {
        public AccountPresenceState Presence { get; private set; }

        public void Read(GamePacketReader reader)
        {
            Presence = reader.ReadEnum<AccountPresenceState>(3u);
        }
    }
}
