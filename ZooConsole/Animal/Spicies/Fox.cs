namespace ZooConsole
{
    public class Fox : Animal
    {
        public Fox(string nickname) : base(nickname)
        {
            CurrentLives = DefaultLives = 3;
            Species = Species.Fox;
        }
    }
}