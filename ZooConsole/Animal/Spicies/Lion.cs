namespace ZooConsole
{
    public class Lion : Animal
    {
        public Lion (string nickname) : base(nickname)
        {
            CurrentLives = DefaultLives = 5;
            Species = Species.Lion;
        }
    }
}