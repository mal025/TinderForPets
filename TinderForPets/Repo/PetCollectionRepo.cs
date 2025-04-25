using System.Diagnostics.Eventing.Reader;
using TinderForPets.Model;

namespace TinderForPets.Repo
{
    public class PetCollectionRepo: IPetRepo
    {
        protected List<Pet> _pets = new List<Pet>();

        public PetCollectionRepo()
        {
            _pets.Add(new Pet(234, "Buster", "Verdens sødeste kat", "flatten.jpg", "Kat", 5, 0));
            _pets.Add(new Pet(3252, "Simba", "En stor mis", "Simba21-1024x683.jpg", "Kat", 2, 0));
            _pets.Add(new Pet(45, "Adolf", "En tysk kat", "tyskkat.jpg", "Kat", 5, 0));
        }

        public List<Pet> GetAll()
        {
            return _pets;
        }
        public virtual void Add(Pet pet)
        {
            _pets.Add(pet);
        }

        public Pet Get(int id)
        {
            foreach (Pet pet in _pets)
            {
                if (id == pet.ID)
                {
                    return pet;
                }
            }
            return null;
        }
    }
}
