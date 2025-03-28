using TinderForPets.Model;

namespace TinderForPets.Repo
{
    public class PetCollectionRepo: IPetRepo
    {
        List<Pet> _pets = new List<Pet>();

        public PetCollectionRepo()
        {
            _pets.Add(new Pet("Buster", "Verdens sødeste kat", "flatten.jpg", "Kat", 5));
            _pets.Add(new Pet("Simba", "En stor mis", "Simba21-1024x683.jpg", "Kat", 2));
            _pets.Add(new Pet("Adolf", "En tysk kat", "tyskkat.jpg", "Kat", 5));
        }

        public List<Pet> GetAll()
        {
            return _pets;
        }
        public void Add(Pet pet)
        {
            _pets.Add(pet);
        }

    }
}
