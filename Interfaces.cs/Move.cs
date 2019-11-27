namespace DiggersAndFliers
{
public interface IMove
{
    string Name { get; set; }

    string FavoriteSnack { get; set; }
    int Speed { get; set; }
    int HowManyFeet { get; set; }
    void Run();
    void Walk();
}
}