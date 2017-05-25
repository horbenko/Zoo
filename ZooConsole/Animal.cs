using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooConsole
{
    public class Animal
    {
        private string _nickname;
        private byte _lives;
        public enum Condition { WellFed, Hungry, Sick, Dead };
        public enum Species { Lion, Tiger, Elephant, Bear, Wolf, Fox }

        public string Nickname { get => _nickname; set => _nickname = value; }
        public byte Lives { get => _lives; set => _lives = value; }
        public Condition TheCondition { get; set; }
        public Species TheSpecies { get; set; }
    }
}