namespace TinderForPets.Model
{
    public class Pet
    {
        Random rand = new Random();

        public string Name { get; set; }
        public string Description { get; set; }
        public string ImagePath { set; get; }
        public int Age { get; set; }
        public string Species { set; get; }
        public int Likes { set; get; }
        public int ID { get; set; }

        public Pet()
        {
            ID = rand.Next(0, 10000000);

        }

        public Pet(int iD, string name, string description, string imagePath, string species, int age, int likes)
        {
            ID = iD;
            Name = name;
            Description = description;
            ImagePath = imagePath;
            Species = species;
            Age = age;
            Likes = likes;
        }
    }
}
