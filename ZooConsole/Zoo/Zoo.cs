using System;
using System.Collections.Generic;
using System.Linq;
using System.Timers;

namespace ZooConsole
{
    class Zoo
    {
        private Dictionary<string, Animal> animals = new Dictionary<string, Animal>();
            
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

            if (!animals.ContainsKey(nickname))
            {
                animals.Add(nickname, animal);
            }
            else { Console.WriteLine("FAIL! Nickname of the animal already exist!"); }
        }
 
        public void Feed(string nickname)
        {
            if (animals.ContainsKey(nickname))
            {
                var animal = animals[nickname];

                if (animal.Condition != Condition.Dead)
                {
                    animal.Condition = Condition.WellFed;
                }
            }
            else { Console.WriteLine("FAIL! Check nickname of the animal!"); }
        }

        public void Cure(string nickname)
        {
            if (animals.ContainsKey(nickname))
            {
                var animal = animals[nickname];

                if (animal.Condition != Condition.Dead && animal.CurrentLives < animal.DefaultLives)
                {
                    animal.CurrentLives += 1;
                }
                else { Console.WriteLine("FAIL! The animal already dead!"); }
            }
            else
            {
                Console.WriteLine("FAIL! Check nickname of the animal!");
            }
        }

        public void Remove(string nickname)
        {
            if (animals.ContainsKey(nickname))
            {
                var animal = animals[nickname];

                if (animal.Condition == Condition.Dead)
                {
                    animals.Remove(nickname);
                }
            }
            else
            {
                Console.WriteLine("FAIL! Check nickname or condition of the animal!");
            }
        }

        public List<Animal> GetActive()
        {
            return animals
                .Select(a => a.Value)
                .Where(a => a.Condition != Condition.Dead)
                .ToList();
        }

        public List<Animal> GetAll()
        {
            return animals
                .Select(a => a.Value)
                .ToList();
        }

        public Animal Get(string nickname)
        {
            if (animals.ContainsKey(nickname))
            {
                var animal = animals[nickname];
                return animal;
            }
            else return null;
        }

        public Animal GetRndActive()
        {
            var active = animals
                .Select(a => a.Value)
                .Where(a => a.Condition != Condition.Dead)
                .ToList();

            if (active.Count() > 1)
            {
                Random rand = new Random();
                return active.ElementAt(rand.Next(0, active.Count));
            }
            else if (active.Count() == 1)
            {
                return active.FirstOrDefault();
            }
            else return null;
        }
    }
}
