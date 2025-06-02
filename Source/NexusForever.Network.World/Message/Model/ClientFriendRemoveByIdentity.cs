using NexusForever.Game.Static.Contact;
using NexusForever.Network.Message;
using NexusForever.Network.World.Message.Model.Shared;

namespace NexusForever.Network.World.Message.Model
{
    [Message(GameMessageOpcode.ClientFriendRemoveByIdentity)]
    public class ClientFriendRemoveByIdentity : IReadable
    {
        public TargetPlayerIdentity PlayerIdentity { get; private set; } = new();
        public ContactType Type { get; private set; }

        public void Read(GamePacketReader reader)
        {
            PlayerIdentity.Read(reader);
            Type = reader.ReadEnum<ContactType>(4u);
        }
    }
}
