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


        private readonly ILogger<IndexModel> _logger;

        public List<Pet> Pets { get; set; }

        private PetService _petservice;


        public IndexModel(ILogger<IndexModel> logger, PetService petService)
        {
            _logger = logger;
            Pets = petService.GetAll();
            _petservice = petService;

        }

        public void OnGet()
        {

        }

        public void OnPostLiked(int PetID)
        {
            Pet p = _petservice.Get(PetID);
            p.Likes++;
        }
    }
}
