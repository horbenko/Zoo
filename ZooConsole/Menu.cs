using System;

namespace ZooConsole
{
    class Menu
    {

        int value;
        string line = null;

        public void MenuChoise(Zoo zoo)
        {
            ZooConsoleApp zooConsoleApp = new ZooConsoleApp();

            do
            {
                Console.Write("   -----\n   Menu:\n   ----- \n1 Add animal \n2 Feed animal \n3 Cure animal \n4 Remove dead animal \n" +
                        "5 Display all active/live animal \n6 Display all animals \n0 Exit the program / or press Esc  \n\nMake your choise: ");

                value = KeyboardInt();
                    switch (value)
                    {
                        case 1:
                            Console.Write("You want to add an animal. Type nickname and then spices (for example - Smart Fox): ");
                            line = KeyboardStr();
                            string[] array = line.Split(' ');
                            try
                            {
                                var content = (Species)Enum.Parse(typeof(Species), array[1]);
                                zoo.Add(array[0], content);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("FAIL! Check spices of the animal! " +
                                    "Accepted next spices: Lion, Tiger, Elephant, Bear, Wolf, Fox");
                            }
                            break;
                        case 2:
                            Console.Write("You want to feed an animal. Enter nickname: ");
                            line = KeyboardStr();
                            zoo.Feed(line);
                            break;
                        case 3:
                            Console.Write("You want to cure an animal. Enter nickname: ");
                            line = KeyboardStr();
                            zoo.Cure(line);
                            break;
                        case 4:
                            Console.Write("You want to remove dead animal. Enter nickname: ");
                            line = KeyboardStr();
                            zoo.Remove(line);
                            break;
                        case 5:
                            zooConsoleApp.DisplayAllActive();
                            break;
                        case 6:
                            zooConsoleApp.DisplayAll();
                            break;
                        case 0:
                            Console.WriteLine("Exit the program.");
                            break;
                        default:
                            Console.WriteLine("Make your choise from the list! Press 1, 2, 3, 4, 5, 6 or 0 digit.");
                            break;
                    }
            }
            
            while (value != 0);  //Console.ReadKey().Key != ConsoleKey.Escape
        }

        public int KeyboardInt()
        {
            string line = Console.ReadLine();
            int value;

                if (int.TryParse(line, out value))
                {
                    return value;
                }
                else
                {
                    Console.WriteLine("Not an integer! Enter integer/digit!");
                    return KeyboardInt();
                }     
        }

        public string KeyboardStr()
        {
            return line = Console.ReadLine();
        }

    }
}
