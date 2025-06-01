using NexusForever.Database.Character;
using NexusForever.Game.Abstract.Entity;
using System.Collections;

namespace NexusForever.Game.Entity
{
    public class ContactManager : IContactManager
    {
        public IEnumerator<Contact.Contact> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void Save(CharacterContext context)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
