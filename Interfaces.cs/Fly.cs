namespace DiggersAndFliers
{
public interface IFly
{
    string Name { get; set; }

    string FavoriteSnack { get; set; }
    int MaximumHeight { get; }
    int Speed { get; set; }
    string WingSpan { get; set; }
    void Fly();

}
}