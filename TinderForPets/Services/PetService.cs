using TinderForPets.Model;
using TinderForPets.Repo;

namespace TinderForPets.Services
{
    public class PetService
    {

        private IPetRepo _petRepo; // Creates a new instance for pet repository


        public PetService(IPetRepo petRepo)
        {
            _petRepo = petRepo;

        }

        public List<Pet> GetAll()
        {
            return _petRepo.GetAll();
        }

        public void Add(Pet pet)
        {
            _petRepo.Add(pet);
        }

    }
}
