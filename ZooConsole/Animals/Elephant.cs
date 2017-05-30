namespace ZooConsole.Animals
{
    public class Elephant : Animal
    {
        public Elephant(string nickname) 
            : base(nickname)
        {
            CurrentLives = DefaultLives = 7;
        }
    }
}