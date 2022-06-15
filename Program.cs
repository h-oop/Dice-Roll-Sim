// weee DICE ROLLER
Console.Clear();
#nullable disable
bool loop = true;

// MAKE FUNCTION THAT ROLLS THE DIE THEN LOOP THAT FOR EACH NEED?


while (loop) {

  Console.WriteLine("\nDice Roll Sim menu.");
  Console.WriteLine("1. Roll dice once");
  Console.WriteLine("2. Roll dice 5 times");
  Console.WriteLine("3. Roll dice 'n' times");
  Console.WriteLine("4. Roll until Snake Eyes");
  Console.WriteLine("5. Exit");
  Console.Write("\nSelect 1-5: ");
  int menuOpt = Convert.ToInt32(Console.ReadLine());
    Random rnd = new Random();
    if (menuOpt == 1) {
        // ROLL 2 DICE
        Console.WriteLine("\nRoll 2");
        int die1 = (rnd.Next(1,7));
        int die2 = (rnd.Next(1,7));
        Console.WriteLine($"{die1},{die2} (sum: {die1+die2})");
    } else if (menuOpt == 2) {
        // ROLL 5 TIMES
        Console.Write("\nRoll 2 dice 5 times");
        for (int i = 0; i<= 5; i++) {
            int die1 = (rnd.Next(1,7));
            int die2 = (rnd.Next(1,7));
            Console.WriteLine($"{die1},{die2} (sum: {die1+die2})");
        }

    } else if (menuOpt == 3) {
        Console.Write("\nRoll n times enter n: ");
        int n = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i<= n; i++) {
            int die1 = (rnd.Next(1,7));
            int die2 = (rnd.Next(1,7));
            Console.WriteLine($"{die1},{die2} (sum: {die1+die2})");
        }
    } else if (menuOpt == 4) {
        // SNAKE EYES
        Console.WriteLine("\nsssssssss"); 
        bool SnakeLoop = true;
        while (SnakeLoop) {
            int die1 = (rnd.Next(1,7));
            int die2 = (rnd.Next(1,7));
            Console.WriteLine($"{die1}, {die2} (sum: {die1+die2})");
            if (die1+die2 == 2) {
                SnakeLoop = false;
            }
        }

    } else if (menuOpt == 5) {
        Console.WriteLine("\ngood riddance");
        loop = false;

    } else {
        Console.WriteLine("\ninvalid");

    }
}