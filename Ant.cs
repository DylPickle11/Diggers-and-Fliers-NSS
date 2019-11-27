using System;

namespace DiggersAndFliers
{
    public class Ant : IDig, IMove
    {
        public string Name { get; set; }
        public string FavoriteSnack { get; set; }
        public int Speed { get; set; }
        public int HowManyFeet { get; set; }
        public string Type { get; set; }

        public int MaximumDepth { get; set; }

        public string TypeOfFeet { get; set; }

        public void Dig()
        {
            Console.WriteLine("Scurry");
        }

        public void Run()
        {
            Console.WriteLine("Frantically");
        }

        public void Walk()
        {
            Console.WriteLine("Antily");
        }
    };
}