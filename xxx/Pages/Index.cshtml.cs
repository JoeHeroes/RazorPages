using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Xml.Serialization;
using xxx.Class;

namespace xxx.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }


        public IActionResult OnPost()
        {

            var person = new Person();
            person.imie = Request.Form["imie"];
            person.nazwisko = Request.Form["nazwisko"];
            person.wiek = int.Parse(Request.Form["wiek"]);
            person.plec = Request.Form["plec"];
            person.telefon = int.Parse(Request.Form["telefon"]);
            person.jezyki = Request.Form["jezyk"].ToString();


            if (person.wiek < 18)
            {
                return RedirectToPage("tooYoung");
            }

            return RedirectToPage("welcome", person);

        }
    }
}