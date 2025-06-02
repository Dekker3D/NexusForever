using NexusForever.Game.Static.Contact;
using NexusForever.Network.Message;

namespace NexusForever.Network.World.Message.Model
{
    [Message(GameMessageOpcode.ClientFriendInviteResponse)]
    public class ClientFriendInviteResponse : IReadable
    {
        public ulong InviteId { get; private set; }
        public ContactResponse Response { get; private set; }

        public void Read(GamePacketReader reader)
        {
            InviteId = reader.ReadULong();
            Response  = reader.ReadEnum<ContactResponse>(3u);
        }
    }
}
