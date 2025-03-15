namespace QHughes_Roguelike
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isPlaying = true;
            Console.WriteLine("You hold the gem key close...");

            int roomIndex = 0;
            Room[] rooms = InitializeRooms();

            while (isPlaying)
            {
                string? userInput = Console.ReadLine();
                if (userInput != null)
                {
                    if (!Enum.TryParse<Command>(userInput, out Command userCommand))
                    {
                        Console.WriteLine("Invalid Input: No Command Found.");
                    }
                    switch (userCommand)
                    {
                        case Command.quit:
                            Console.WriteLine("Thanks for playing!");
                            isPlaying = false;
                            break;
                        case Command.look:
                            Console.WriteLine(rooms[roomIndex].Description);
                            break;
                        case Command.attack:
                            Console.WriteLine("You swing your fist");
                            if (rooms[roomIndex].Enemy != null)
                            {
                                if (rooms[roomIndex].Enemy.isAlive)
                                    {
                                    rooms[roomIndex].Enemy.TakeDamage(1);
                                    if (!rooms[roomIndex].Enemy.isAlive)
                                    {
                                        Console.WriteLine("Its dead now.");
                                    }
                                }
                                else 
                                {
                                    Console.WriteLine("No enemies remain alive."); 
                                }
                               
                            }
                            else
                            {
                                Console.WriteLine("There's nothing to attack");
                            }
                            break;
                        case Command.moveforward:
                            Console.WriteLine("You moved forward");
                            roomIndex++;
                            if (roomIndex == rooms.Length)
                            {
                                Console.WriteLine("You have reached the end of the game.");
                                isPlaying = false;
                            }
                            else
                            {
                                Console.WriteLine(rooms[roomIndex].Description);
                            }
                            break;
                        case Command.movebackward:
                            roomIndex--;
                            if (roomIndex < 0)
                            {
                                roomIndex = 0;
                                Console.WriteLine("You can't go back.");
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid Input: Command without a case.");
                            break;
                    }
                }

            }
        }
        private static Room[] InitializeRooms()
        {
            Room[] rooms = new Room[6];
            rooms[0] = new Room("Bridge Start", "You start at the edge of a bridge.");
            rooms[1] = new Room("Bridge Edge", "You teeter on the edge of the bridge.");
            rooms[2] = new Room("Under Bridge", "You are in the muck beneath the bridge.");
            rooms[3] = new Room("Road to Town", "You are at the road to town.");
            rooms[4] = new Room("Dark Alley", "You're amongst the shadows of a dark alley way.");
            rooms[5] = new Room("Grand Cave", "Before you is the mouth of a grand cave.");
            return rooms;
        }
    }
}
