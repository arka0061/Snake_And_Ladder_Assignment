﻿using System;

namespace Snake_And_Ladder_Assignment
{
    class Program
    {
        public static int player_Position = 0;
        public static int dice = 0;
        public static int check=0;
        public int board = 0;
        int counter = 0;
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

            while (board <= 120)
            {
                Console.WriteLine("Press Enter to roll the dice");
                roll_Dice = Console.ReadLine();
                Random random = new Random();
                dice = random.Next(1, 7);
                check = random.Next(0, 3);
                switch (check)
                {
                    case 0:
                        Console.WriteLine("You got a No Play!");
                        Console.WriteLine("Your position is : " + board);
                        counter++;
                        break;

                    case 1:
                        board = board + dice;
                        Console.WriteLine("You got a Ladder!");
                        Console.WriteLine("Your position is : " + board);
                        counter++;
                        break;

                    case 2:
                        board = board - dice;
                        Console.WriteLine("You got a Snake!");
                        Console.WriteLine("Your position is : " + board);
                        counter++;
                        break;

                    default:
                        Console.WriteLine("Error");
                        break;

                }
                if(board>100)
                {
                    board = board - dice;
                    Console.WriteLine("Your position is above 100: Resetting to previous position : "+board);
                   
                }
                if(board==100)
                {
                    break;
                }
            }
            Console.WriteLine("Congratulatuons!You have won the game,Your positon is :" + board + " " + "Number of times dice rolled : " + counter);


        }
        }

    }

