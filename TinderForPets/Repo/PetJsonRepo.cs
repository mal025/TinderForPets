using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using TinderForPets.Model;
using System.IO;
namespace TinderForPets.Repo
{
    public class PetJsonRepo: PetCollectionRepo
    {

        public PetJsonRepo()
        {
            LoadFile();

        }
        private void LoadFile()
        {
            string path = "pets.json";
            string json = File.ReadAllText(path);
            _pets = JsonSerializer.Deserialize<List<Pet>>(json);

        }
        public override void Add(Pet pet)
        {
            base.Add(pet);
            SaveFile(pet);
        }
        private void SaveFile(Pet pet)
        {
            string path = "pets.json";
            File.WriteAllText(path, JsonSerializer.Serialize(_pets));
        }
    }
}
