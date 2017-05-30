namespace ZooConsole.Animals
{
    public class Lion : Animal
    {
        public Lion (string nickname) 
            : base(nickname)
        {
            CurrentLives = DefaultLives = 5;
        }
    }
}