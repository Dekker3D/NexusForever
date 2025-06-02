using NexusForever.Game.Abstract.Entity;
using NexusForever.Shared.Configuration;

namespace NexusForever.Game.Abstract.Contact
{
    public interface IGlobalContactManager
    {
        public float GetMaxRequestDurationInDays();
        public ulong NextContactId { get; }
        public void Initialise();
        public IEnumerable<IContact> GetQueuedRequests(ulong ownerId);
        public void DeclineRequest(IContact contact);
        public void AcceptRequest(IContact contact);
        public void SubscribeTo(ulong characterId, IEnumerable<ulong> characterIdList);
        public void UnsubscribeFrom(ulong characterId, List<ulong> characterIdList);
        public void RemoveSubscriber(ulong characterId);
        public void NotifySubscribers(ulong characterId, bool loggingOut = false);
        public void NotifySubscriber(ulong subscriberId, ulong contactCharacterId, bool loggingOut = false);
        public void SendRequestToPlayer(IContact contactRequest);
        public void TryRemoveRequestFromOnlineUser(IContact contactRequest);
    }
}
