using System;

namespace DiggersAndFliers
{
    public class Fish : ISwim
    {
        public string Name { get; set; }
        public string FavoriteSnack { get; set; }
        public string Type { get; set; }

        public int MaximumDepth { get; set; }

        public int Speed { get; set; }
        public string TypeOfFeet { get; set; }
        public string TypeOfPaddling { get; set; }

        public void Swim()
        {
            Console.WriteLine("Swim Swim");
        }
    }
}