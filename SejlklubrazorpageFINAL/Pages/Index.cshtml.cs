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
        }
    }
}
