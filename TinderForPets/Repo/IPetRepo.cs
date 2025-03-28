using TinderForPets.Model;

namespace TinderForPets.Repo
{
    public interface IPetRepo
    {
        public List<Pet> GetAll();
        public void Add(Pet pet);
    }
}
