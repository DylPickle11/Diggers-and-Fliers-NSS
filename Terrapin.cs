using System;

namespace DiggersAndFliers
{
    public class Terrapin : ISwim, IMove
    {
        public string Name { get; set; }
        public string FavoriteSnack { get; set; }

        public int MaximumDepth { get; set; }

        public int Speed { get; set; }
        public string TypeOfFeet { get; set; }
        public string TypeOfPaddling { get; set; }
        public string Type { get; set; }
        public int HowManyFeet { get; set; }

        public void Run()
        {
            Console.WriteLine("Slow motion");
        }

        public void Swim()
        {
            Console.WriteLine("Swim Swim");
        }

        public void Walk()
        {
            Console.WriteLine("Slow slow slow motion");
        }
    }
}