using System;
using System.Collections.Generic;
using System.Linq;
using ZooConsole.Animals;
using ZooConsole.Animals.Settings;

namespace ZooConsole.ZooManagement
{
    internal class Zoo
    {
        private readonly Dictionary<string, Animal> _animals = new Dictionary<string, Animal>();
            
        public void Add(string nickname, Species spices)
        {
            Animal animal = null;

            switch (spices)
            {
                case Species.Bear:
                    animal = new Bear(nickname);                   
                    break;

                case Species.Elephant:
                    animal = new Elephant(nickname);
                    break;

                case Species.Fox:
                    animal = new Fox(nickname);
                    break;

                case Species.Lion:
                    animal = new Lion(nickname);
                    break;

                case Species.Tiger:
                    animal = new Tiger(nickname);
                    break;

                case Species.Wolf:
                    animal = new Wolf(nickname);
                    break;
            }

            if (!_animals.ContainsKey(nickname))
            {
                _animals.Add(nickname, animal);
            }
            else
            {
                Console.WriteLine("FAIL! Nickname of the animal already exist!");
            }
        }
 
        public void Feed(string nickname)
        {
            if (_animals.ContainsKey(nickname))
            {
                var animal = _animals[nickname];

                if (animal.Condition != Condition.Dead)
                {
                    animal.Condition = Condition.WellFed;
                }
            }
            else
            {
                Console.WriteLine("FAIL! Check nickname of the animal!");
            }
        }

        public void Cure(string nickname)
        {
            if (_animals.ContainsKey(nickname))
            {
                var animal = _animals[nickname];

                if (animal.Condition != Condition.Dead && animal.CurrentLives < animal.DefaultLives)
                {
                    animal.CurrentLives += 1;
                }
                else
                {
                    Console.WriteLine("FAIL! The animal already dead!");
                }
            }
            else
            {
                Console.WriteLine("FAIL! Check nickname of the animal!");
            }
        }

        public void Remove(string nickname)
        {
            if (_animals.ContainsKey(nickname))
            {
                var animal = _animals[nickname];

                if (animal.Condition == Condition.Dead)
                {
                    _animals.Remove(nickname);
                }
            }
            else
            {
                Console.WriteLine("FAIL! Check nickname or condition of the animal!");
            }
        }

        public List<Animal> GetAllActive()
        {
            return GetAll()
                .Where(a => a.Condition != Condition.Dead)
                .ToList();
        }

        public List<Animal> GetAll()
        {
            return _animals
                .Select(a => a.Value)
                .ToList();
        }

        public Animal Get(string nickname)
        {
            return _animals.ContainsKey(nickname) 
                ? _animals[nickname] 
                : null;
        }

        public Animal GetRndActive()
        {
            var active = GetAllActive();

            if (active.Count == 0)
                return null;

            if (active.Count == 1)
                return active.First();

            var rand = new Random();

            return active.ElementAt(rand.Next(0, active.Count));
        }
    }
}