
namespace DiggersAndFliers
{
    public interface IDig
    {
        string Name { get; set; }

        string FavoriteSnack { get; set; }
        int MaximumDepth { get; }
        int Speed { get; set; }
        string TypeOfFeet { get; set; }
        void Dig();

    }
}