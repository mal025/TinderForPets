using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TinderForPets.Model;
using TinderForPets.Services;

namespace TinderForPets.Pages
{
    public class CreateModel : PageModel
    {
        private PetService _petService;
        [BindProperty]
        public Pet Pet { get; set; }

        public CreateModel(PetService petService)
        {
            _petService = petService;
            Pet = new Pet();
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            Debug.WriteLine("efwef " + Pet.Name);
            _petService.Add(Pet);
            return RedirectToPage("/index");
        }

    }
}
