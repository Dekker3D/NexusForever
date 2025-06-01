using NexusForever.Game.Static.Friend;
using NexusForever.Network.Message;
using NexusForever.Network.World.Message.Model.Shared;

namespace NexusForever.Network.World.Message.Model
{
    [Message(GameMessageOpcode.ClientFriendAccountAddByIdentity)]
    public class ClientFriendAccountAddByIdentity : IReadable
    {
        public TargetPlayerIdentity Target { get; set; } // Match the account from the target's identity
        public FriendshipType Type { get; set; }
        public string Note { get; set; } // Optional note sent with invite

        public void Read(GamePacketReader reader)
        {
            Target = new TargetPlayerIdentity();
            Target.Read(reader);
            Type = (FriendshipType) reader.ReadByte(4u);
            Note = reader.ReadWideString();
        }

        public void Write(GamePacketWriter writer)
        {
            Target.Write(writer);
            writer.Write(Type, 4u);
            writer.WriteStringWide(Note);
        }
    }
}
