using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Xml.Serialization;

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


        public IActionResult onPost()
        {
            string _firstname = Request.Form["imie"];
            string _secondname = Request.Form["nazwisko"];

            return RedirectToPage("welcome",new { firstname = _firstname , secondname = _secondname});

        }
    }
}