using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SejlklubLibraryFINAL;

namespace SejlklubrazorpageFINAL.Pages
{
    public class IndexModel : PageModel
    {
        public List<Event> Events { get; private set; }
        public void OnGet()
        {
            EventRepository eventRepo = new EventRepository();
            Events = eventRepo.GetAllEvents();
            
            //  This is just events for testing.
            Event testEvent1 = new Event("Hygge Sejlads", new DateOnly(2026, 04, 14), new TimeOnly(16, 30), "Lidt hygge sejlads", "Hillerød", new Guid());
            Event testEvent2 = new Event("Hygge Sejlads 2", new DateOnly(2026, 06, 18), new TimeOnly(16, 30), "Lidt hygge sejlads", "Hillerød", new Guid());
            eventRepo.AddEvent(testEvent1);
            eventRepo.AddEvent(testEvent2);
        }
    }
}
