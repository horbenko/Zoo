using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooConsole
{
    class Zoo : IEnumerable
    {
        private List<Animal> animals = new List<Animal>();

        public IEnumerator GetEnumerator()
        {
            foreach (Animal theAnimal in animals)
            {
                yield return theAnimal.Nickname;
            }
        }

        public void Add(string nickname, Animal.Species spices)
        {
            animals.Add(new Animal { Nickname = nickname, TheSpecies = spices });
        }

    }
}
