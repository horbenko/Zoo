using ZooConsole.Animals.Settings;

namespace ZooConsole.Animals
{
    public abstract class Animal
    {
        protected Animal(string nickname)
        {
            Nickname = nickname;
            Condition = Condition.WellFed;            
        }


        public string Nickname { get; set; }

        public byte DefaultLives { get; set; }

        public byte CurrentLives { get; set; }

        public Condition Condition { get; set; }
    }
}