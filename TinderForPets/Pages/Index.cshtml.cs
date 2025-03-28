using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using TinderForPets.Model;
using TinderForPets.Repo;
using TinderForPets.Services;

namespace TinderForPets.Pages
{
    public class IndexModel : PageModel
    {

        //  public Animal Cat { set;get; }

        // private Pet[] _animals = new Pet[3];

        private readonly ILogger<IndexModel> _logger;

        public List<Pet> Pets { get; set; }

        // public Pet[] Pets { get => _animals; set => _animals = value; }

        public IndexModel(ILogger<IndexModel> logger, PetService petService)
        {
            _logger = logger;
            Pets = petService.GetAll();

        }

        public void OnGet()
        {

        }
    }
}
