class Program
{
    static void Main()
    {
        Player player = new Player(100);
        House house = new House(1000);
        int round = 1;

        Console.WriteLine("The house has $1000");
        Console.WriteLine("The player has $100");
        Console.WriteLine("Try your luck to win all money of the house!");

        while (player.Money > 0 && house.Money > 0)
        {
            Console.WriteLine($"\nRound {round}:");

            int bet;
            while (true)
            {
                Console.Write("How much do you want to bet? ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out bet))    // check input
                {
                    Console.WriteLine("Invalid input! Try again.");
                    continue;
                }

                if (bet <= 0 || bet > player.Money)
                {
                    Console.WriteLine("You bet more than what in your wallet! Try again!");
                    continue;
                }

                break;
            }

            Console.WriteLine($"You have bet ${bet}!");

            Console.Write("Do you want to bet big or small? (big/small): ");
            string choice = Console.ReadLine().ToLower();

            int[] diceResults = house.RollDice();
            int sum = diceResults[0] + diceResults[1] + diceResults[2];

            Console.WriteLine($"The dices are: {diceResults[0]} {diceResults[1]} {diceResults[2]}");
            Console.WriteLine($"The sum of 3 dices is {sum}!");

            bool isTriple = (diceResults[0] == diceResults[1] && diceResults[1] == diceResults[2]);
            bool isBig = (sum >= 11 && sum <= 17);
            bool isSmall = (sum >= 4 && sum <= 10);

            if (isTriple)
            {
                Console.WriteLine("Triple! You Lost!");
                player.Lose(bet);
                house.Win(bet);
            }
            else if ((choice == "big" && isBig) || (choice == "small" && isSmall))
            {
                Console.WriteLine($"You Won ${bet}!");
                player.Win(bet);
                house.Lose(bet);
            }
            else
            {
                Console.WriteLine($"You Lost ${bet}!");
                player.Lose(bet);
                house.Win(bet);
            }

            Console.WriteLine($"The house has ${house.Money}");
            Console.WriteLine($"The player has ${player.Money}");

            if (player.Money <= 0 || house.Money <= 0) break;

            Console.Write("Do you still want to continue to play? (true/false): ");
            string cont = Console.ReadLine().ToLower();

            if (cont != "true") break;

            round++;
        }

        Console.WriteLine(player.Money <= 0 ? "\nYou ran out of money! Game over!" :
                          house.Money <= 0 ? "\nYou won all the house's money! Congrats!" :
                          "\nThanks for playing!");
    }
}