using NexusForever.Network.Message;
using NexusForever.Network.World.Message.Model.Shared;

namespace NexusForever.Network.World.Message.Model
{
    [Message(GameMessageOpcode.ServerFriendList)]
    public class ServerFriendList : IWritable
    {
        public List<FriendData> Contacts { get; set; } = [];

        public void Write(GamePacketWriter writer)
        {
            writer.Write(Contacts.Count, 16u);
            Contacts.ForEach(f => f.Write(writer));
        }
    }
}
