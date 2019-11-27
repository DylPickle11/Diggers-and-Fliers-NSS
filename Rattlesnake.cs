using System;

namespace DiggersAndFliers
{
    public class RattleSnake : IMove
    {
        public string Name { get; set; }
        public string FavoriteSnack { get; set; }
        public int Speed { get; set; }
        public string Type { get; set; }
        public int HowManyFeet { get; set; }

        public void Run()
        {
            Console.WriteLine("Slither");
        }

        public void Walk()
        {
            Console.WriteLine("Slow slither");
        }
    }
}