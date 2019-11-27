using System;

namespace DiggersAndFliers
{
    public class Earthworm : IDig
    {
        public string Name { get; set; }
        public string FavoriteSnack { get; set; }
        public string animalType { get; set; }

        public int MaximumDepth { get; set; }

        public int Speed { get; set; }
        public string TypeOfFeet { get; set; }

        public void Dig()
        {
            Console.WriteLine("Dig");
        }
    }
}