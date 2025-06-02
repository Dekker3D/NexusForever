using NexusForever.Network.Message;
using NexusForever.Network.World.Message.Model.Shared;

namespace NexusForever.Network.World.Message.Model
{
    [Message(GameMessageOpcode.ServerFriendAdd)]
    public class ServerFriendAdd : IWritable
    {
        public ContactData Friend { get; set; } = new ContactData();

        public void Write(GamePacketWriter writer)
        {
            Friend.Write(writer);
        }
    }
}
