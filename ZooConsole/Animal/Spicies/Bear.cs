namespace ZooConsole
{
    public class Bear : Animal
    {
        public Bear(string nickname) : base(nickname)
        {
            CurrentLives = DefaultLives = 6;
            Species = Species.Bear;
        }
    }
}