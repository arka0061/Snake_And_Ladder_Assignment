using System;

namespace Snake_And_Ladder_Assignment
{
    class Program
    {
        public static int player_Position = 0;
        public static int dice = 0;
        public static int check = 0;
        public int board1 = 0;
        public int board2 = 0;
        public int ladder = 0;

        int counter1 = 0;
        int counter2 = 0;
        public static int switch_Player = 0;

        public static void Main(string[] args)
        {
            Program obj = new Program();

            Console.WriteLine("WelCome to Snake and ladder Program!");
            Console.WriteLine("Both Players start at  position :" + player_Position);
            obj.game_start();
        }
        public void game_start()
        {
            String roll_Dice = "";

            while (board1 <= 120 && board2 <= 120)
            {
                if (switch_Player == 0) //Player1
                {
                    Console.WriteLine("Press Enter to roll the dice Player1");
                    roll_Dice = Console.ReadLine();
                    Random random = new Random();
                    dice = random.Next(1, 7);
                    check = random.Next(0, 3);
                    switch (check)
                    {
                        case 0:
                            Console.WriteLine("You got a No Play!");
                            Console.WriteLine("Your position is : " + board1);
                            counter1++;
                            break;

                        case 1:
                            board1 = board1 + dice;
                            Console.WriteLine("You got a Ladder!");
                            Console.WriteLine("Your position is : " + board1);
                            counter1++;
                            break;

                        case 2:
                            board1 = board1 - dice;
                            Console.WriteLine("You got a Snake!");
                            Console.WriteLine("Your position is : " + board1);
                            counter1++;
                            break;

                        default:
                            Console.WriteLine("Error");
                            break;

                    }
                    if (board1 > 101)
                    {
                        board1 = board1 - dice;
                        Console.WriteLine("Your position is above 100: Resetting to previous position : " + board1);

                    }
                    if (board1 == 100)
                    {
                        break;
                    }
                    if (check == 1)
                    {
                        switch_Player = 0;
                    }
                    else
                    {
                        switch_Player = 1;
                    }
                }
                else //Player2
                {
                    Console.WriteLine("Press Enter to roll the dice Player 2");
                    roll_Dice = Console.ReadLine();
                    Random random = new Random();
                    dice = random.Next(1, 7);
                    check = random.Next(0, 3);
                    switch (check)
                    {
                        case 0:
                            Console.WriteLine("You got a No Play!");
                            Console.WriteLine("Your position is : " + board2);
                            counter1++;
                            break;

                        case 1:
                            board2 = board2 + dice;
                            Console.WriteLine("You got a Ladder!");
                            Console.WriteLine("Your position is : " + board2);
                            counter2++;
                            break;

                        case 2:
                            board2 = board2 - dice;
                            Console.WriteLine("You got a Snake!");
                            Console.WriteLine("Your position is : " + board2);
                            counter2++;
                            break;

                        default:
                            Console.WriteLine("Error");
                            break;

                    }
                    if (board2 > 100)
                    {
                        board2 = board2 - dice;
                        Console.WriteLine("Your position is above 100: Resetting to previous position : " + board2);

                    }
                    if (board2 == 100)
                    {
                        break;
                    }
                    if (check == 1)
                    {
                        switch_Player = 1;
                    }
                    else
                    {
                        switch_Player = 0;
                    }

                }
               

            }
            if (board1 == 100)
            {
                Console.WriteLine("Congratulations Player1!You have won the game,Your positon is :" + board1 + " " + "Number of times dice rolled : " + counter1);

            }
            if (board2 == 100)
            {
                Console.WriteLine("Congratulations Player2!You have won the game,Your positon is :" + board2 + " " + "Number of times dice rolled : " + counter2);
            }

        }
    }
}
        


    

