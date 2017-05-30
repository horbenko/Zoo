namespace ZooConsole.Animals
{
    public class Wolf : Animal
    {
        public Wolf(string nickname) 
            : base(nickname)
        {
            CurrentLives = DefaultLives = 4;
        }
    }
}