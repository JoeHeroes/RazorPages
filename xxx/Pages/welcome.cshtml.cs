using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using xxx.Class;

namespace xxx.Pages
{
    public class welcomeModel : PageModel
    {
        Person person;
        public void OnGet(Person person)
        {
            ViewData["imie"] = person.imie;
            ViewData["nazwisko"] = person.nazwisko;
            ViewData["wiek"] = person.wiek;
            ViewData["plec"] = person.plec;
            ViewData["telefon"] = person.telefon;
            ViewData["jezyki"] = person.jezyki;
        }
    }
}
