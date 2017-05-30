namespace ZooConsole.Animals
{
    public class Tiger : Animal
    {
        public Tiger(string nickname) 
            : base(nickname)
        {
            CurrentLives = DefaultLives = 4;
        }
    }
}