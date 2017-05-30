using System;
using System.Threading;
using ZooConsole.Animals.Settings;
using ZooConsole.ZooManagement;

namespace ZooConsole
{
    internal class ZooConsoleApp
    {
        private static Zoo _zoo;
        private static Timer _timer;

        static void Main(string[] args)
        {
            var eventInterval = 5000;

            Console.Title = "Zoo";
            Console.WriteLine("<-------- You are in the console emulator of life in a zoo. --------> ");
            Console.WriteLine("The zoo already has animals: by one for each available species.");
            Console.WriteLine("With a constant period of time (every 5 seconds) events occurs in the zoo.");
            
            _zoo = new Zoo();
            var menu = new Menu();

            // Animals added by default
            _zoo.Add("Baako", Species.Bear);
            _zoo.Add("Eamon", Species.Elephant);
            _zoo.Add("Fabio", Species.Fox);
            _zoo.Add("Lacey", Species.Lion);
            _zoo.Add("Tad", Species.Tiger);
            _zoo.Add("Walcott", Species.Wolf);

            _timer = new Timer(Event, null, 0, eventInterval);

            menu.MenuChoise(_zoo);
            Console.WriteLine("<-------- The program finished its work. --------> ");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        public static void Event(object obj)
        {
            var animal = _zoo.GetRndActive();

            if (animal != null)
            {
                switch (animal.Condition)
                {
                    case Condition.WellFed:
                        animal.Condition = Condition.Hungry;
                        break;

                    case Condition.Hungry:
                        animal.Condition = Condition.Sick;
                        break;

                    case Condition.Sick:
                        if (animal.CurrentLives > 1)
                        {
                            animal.CurrentLives -= 1;
                        }
                        else if (animal.CurrentLives == 1)
                        {
                            animal.Condition = Condition.Dead;
                            animal.CurrentLives = 0;
                        }
                        break;

                    default: // TODO Show message
                        break;
                }
            }
            else
            {
                _timer.Dispose();
                Console.WriteLine("All animals in the zoo are dead!");
            }
        }

        public static void DisplayAll()
        {
            var animals = _zoo.GetAll();

            Console.WriteLine("The list of all animals in the zoo: ");

            foreach (var a in animals)
            {
                Console.WriteLine($"Nickname: {a.Nickname}, spices: {a.GetType().Name}, lives: {a.CurrentLives}, condition: {a.Condition}.");
            }
        }

        public static void DisplayAllActive()
        {
            var activeAnimals = _zoo.GetAllActive();

            if (activeAnimals.Capacity != 0)
            {
                Console.WriteLine("The list of all active animals: ");
                foreach (var a in activeAnimals)
                {
                    Console.WriteLine($"Nickname: {a.Nickname}, spices: {a.GetType().Name}, lives: {a.CurrentLives}, condition: {a.Condition}.");
                }
            }
            else
            {
                Console.WriteLine("The list of all active animals is empty!");
            }            
        }
    }
}