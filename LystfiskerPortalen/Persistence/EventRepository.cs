using LystfiskerPortalen.Data;
using LystfiskerPortalen.Models;


namespace LystfiskerPortalen.Persistence
{
    public class EventRepository : IEventRepository
    {
        private readonly LystFiskerContext context;

        public EventRepository(LystFiskerContext context)
        {
            this.context = context;
        }
        public Event Add(Event evnt)
        {
            context.Events.Add(evnt);
            context.SaveChanges();
            return evnt;

        }
        public void Delete(int id)
        {
            context.Events.Remove(GetById(id));
            context.SaveChanges();
        } 
        public List<Event> GetAllEvents()
        {
            return context.Events.ToList();
        }
        public Event? GetById(int id)
        {
            return context.Events.Find(id);
        }
        public void Update(Event evnt)
        {
            context.Events.Update(evnt);
        }



    }
}
