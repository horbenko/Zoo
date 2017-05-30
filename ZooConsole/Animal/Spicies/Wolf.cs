namespace ZooConsole
{
    public class Wolf : Animal
    {
        public Wolf(string nickname) : base(nickname)
        {
            CurrentLives = DefaultLives = 4;
            Species = Species.Wolf;
        }
    }
}