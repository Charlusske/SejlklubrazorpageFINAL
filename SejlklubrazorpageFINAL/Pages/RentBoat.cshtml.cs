using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SejlklubrazorpageFINAL.Pages
{
    public class RentBoatModel : PageModel
    {
        [BindProperty]
        public string ChooseBoat { get; set; }
        [BindProperty]
        public DateTime Date { get; set; }

        [BindProperty]
        public TimeSpan StartTime { get; set; }

        [BindProperty]
        public TimeSpan EndTime { get; set; }
        public List<string> Boat { get; set; }
        public string Message { get; set; }

        public void OnGet()
        {
            Boat = new List<string> { "Optimistjolle", "Tera jollen", "Feva jollen", "Laser jollen", "Europajollen", "Snipe jollen", "Wayfarer jollen", "Lynæs 14 jollen" };
        }

        public void OnPost()
        {
            OnGet(); 

            if (string.IsNullOrEmpty(ChooseBoat) || Date == default || StartTime == default || EndTime == default)
            {
                Message = "Udfyld venligst alle felter.";
                return;
            }

            if (EndTime <= StartTime)
            {
                Message = "Sluttid skal være senere end starttid.";
                return;
            }

        }

    }

}