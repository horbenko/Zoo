namespace ZooConsole
{
    public class Tiger : Animal
    {
        public Tiger(string nickname) : base(nickname)
        {
            CurrentLives = DefaultLives = 4;
            Species = Species.Tiger;
        }
    }
}