
using LystfiskerPortalen.Models;

namespace LystfiskerPortalen.Persistence
{
    public interface IEventRepository
    {
        List<Event> GetAllEvents();
        Event? GetById(int id);
        Event Add(Event evnt);
        void Delete(int id);
        void Update(Event evnt);

    }
}