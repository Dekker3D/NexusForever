using NexusForever.Database.Character;

namespace NexusForever.Game.Abstract.Entity
{
    public interface IContactManager : IEnumerable<Contact.IContact>, IDatabaseCharacter
    {
    }
}
