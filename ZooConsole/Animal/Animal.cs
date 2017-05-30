namespace ZooConsole
{
    public class Animal
    {
        public Animal(string nickname)
        {
            Nickname = nickname;
            Condition = Condition.WellFed;            
        }

        public string Nickname { get; set; }

        public byte DefaultLives { get; set; }

        public byte CurrentLives { get; set; }

        public Condition Condition { get; set; }

        public Species Species { get; set; }
    }
}