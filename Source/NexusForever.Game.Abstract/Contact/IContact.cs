using NexusForever.Database.Character;
using NexusForever.Game.Static.Contact;

namespace NexusForever.Game.Abstract.Contact
{
    public interface IContact : IDatabaseCharacter
    {
        public ulong OwnerId { get; }
        public ulong Id { get; }
        public ulong ContactId { get; }

        public string InviteMessage { get; set; }
        public string PrivateNote { get; set; }
        public ContactType Type { get; set; }
        public DateTime RequestTime { get; set; }

        public bool IsPendingAcceptance { get; }
        public bool IsPendingCreate { get; }
        public bool IsPendingDelete { get; }

        public void AcceptRequest();
        public void DeclineRequest();
        public void MakePendingAcceptance();
        public void EnqueueDelete();
    }
}
