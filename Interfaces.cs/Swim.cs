namespace DiggersAndFliers
{
    public interface ISwim
    {
        string Name { get; set; }

        string FavoriteSnack { get; set; }
        int MaximumDepth { get; set; }
        int Speed { get; set; }
        string TypeOfFeet { get; set; }
        string TypeOfPaddling { get; set; }
        void Swim();

    }
}