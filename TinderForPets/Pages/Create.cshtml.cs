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
        public Pet pet { get; set; }

        public CreateModel(PetService petService)
        {
            _petService = petService;
            pet = new Pet();
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            Debug.WriteLine("efwef" + pet.Name);
            _petService.Add(pet);

            return RedirectToPage("/index");
        }

    }
}
