using NexusForever.Database.Character;
using NexusForever.Game.Abstract.Contact;

namespace NexusForever.Game.Abstract.Entity
{
    public interface IContactManager : IEnumerable<IContact>, IDatabaseCharacter
    {
    }
}
