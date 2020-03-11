using System;

namespace Rent {
    class Program {
        static void Main(string[] args) {
            Console.Write("How many rooms will be rented? ");
            int alug = int.Parse(Console.ReadLine());

            Rooms[] room = new Rooms[10];

            int rent = 1;
            for (int i = 0; i < alug; i++) {
                Console.WriteLine("Rent #" + rent);

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Room(0 to 9): ");
                int quarto = int.Parse(Console.ReadLine());

                room[quarto] = new Rooms(name, email);

                rent++;

                Console.WriteLine();

            }

            Console.WriteLine("Busy rooms");
            for (int i = 0; i < 10; i++) {
                if (room[i] != null) {
                    Console.WriteLine(i + ": " + room[i]);
                }
            }
        }
    }
}
