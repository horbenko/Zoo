namespace ZooConsole
{
    public class Elephant : Animal
    {
        public Elephant(string nickname) : base(nickname)
        {
            CurrentLives = DefaultLives = 7;
            Species = Species.Elephant;
        }
    }
}