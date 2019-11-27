using System;

namespace DiggersAndFliers
{
    public class Finch : IFly
    {
        public string Name { get; set; }
        public string FavoriteSnack { get; set; }
        public string Type { get; set; }

        public int MaximumHeight { get; set; }

        public int Speed { get; set; }
        public string WingSpan { get; set; }
        public void Fly()
        {
            Console.WriteLine("Swoosh");
        }
    }
}