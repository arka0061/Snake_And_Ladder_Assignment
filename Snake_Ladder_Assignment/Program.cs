using System;

namespace Snake_And_Ladder_Assignment
{
    class Program
    {
        public static int player_Position = 0;
        public static int dice = 0;
        public static  void Main(string[] args)
        {
            Program obj = new Program();
           
            Console.WriteLine("WelCome to Snake and ladder Program!");
            Console.WriteLine("Single Player start at  position :"+ player_Position);
            obj.game_start();
         }
        public void game_start()
        {
           String roll_Dice = "";
           
                Console.WriteLine("Press Enter to roll the dice");
                roll_Dice = Console.ReadLine();
                Random random = new Random();
                dice = random.Next(1, 7);
            Console.WriteLine(dice);


        }
        }

    }

