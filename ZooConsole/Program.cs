using System;
using System.Threading;

namespace ZooConsole
{
    class ZooConsoleApp
    {
        static Zoo zoo;
        static TimerCallback tm;
        static Timer timer;

        static void Main(string[] args)
        {
            int eventInterval = 5000;

            Console.Title = "Zoo";
            Console.WriteLine("<-------- You are in the console emulator of life in a zoo. --------> ");
            Console.WriteLine("The zoo already has animals: by one for each available species.");
            Console.WriteLine("With a constant period of time (every 5 seconds) events occurs in the zoo.");
            
            zoo = new Zoo();
            Menu menu = new Menu();

            // Animals added by default
            zoo.Add("Baako", Species.Bear);
            zoo.Add("Eamon", Species.Elephant);
            zoo.Add("Fabio", Species.Fox);
            zoo.Add("Lacey", Species.Lion);
            zoo.Add("Tad", Species.Tiger);
            zoo.Add("Walcott", Species.Wolf);

            tm = new TimerCallback(Event);
            timer = new Timer(tm, null, 0, eventInterval);

            menu.MenuChoise(zoo);
            Console.WriteLine("<-------- The program finished its work. --------> ");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        public static void Event(object obj)
        {
            var animal = zoo.GetRndActive();

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
                timer.Dispose();
                Console.WriteLine("All animals in the zoo are dead!");
            }
        }

        public void DisplayAll()
        {
            var animals = zoo.GetAll();

            Console.WriteLine("The list of all animals in the zoo: ");

            foreach (var a in animals)
            {
                Console.WriteLine($"Nickname: {a.Nickname}, spices: {a.Species}, lives: {a.CurrentLives}, condition: {a.Condition}.");
            }
        }

        public void DisplayAllActive()
        {
            var activeAnimals = zoo.GetActive();

            if (activeAnimals.Capacity != 0)
            {
                Console.WriteLine("The list of all active animals: ");
                foreach (var a in activeAnimals)
                {
                    Console.WriteLine($"Nickname: {a.Nickname}, spices: {a.Species}, lives: {a.CurrentLives}, condition: {a.Condition}.");
                }
            }
            else
            {
                Console.WriteLine("The list of all active animals is empty!");
            }
            
        }

    }
}