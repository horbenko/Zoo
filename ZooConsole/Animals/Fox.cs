namespace ZooConsole.Animals
{
    public class Fox : Animal
    {
        public Fox(string nickname) 
            : base(nickname)
        {
            CurrentLives = DefaultLives = 3;
        }
    }
}