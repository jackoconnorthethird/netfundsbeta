﻿using System;

namespace fund1beta
{
    class Program
    {
        static void Main(string[] args)
        {
            // int numRings = 2;// change number of rings here
            // if (numRings >= 5)
            // {
            //     Console.WriteLine("You are welcome to join the party");
            // }
            // else if (numRings > 2)
            // {
            //     Console.WriteLine($"Decent...but {numRings} rings aren't enough");
            // }
            // else
            // {
            //     Console.WriteLine("Go win some more rings");
            // }
            ///////////////
            // int numRings = 5;
            // string name = "Kobe";
            // if (numRings >= 5 && name == "Kobe")
            // {
            // Console.WriteLine($"Welcome to the party {name}, congratulations on your {numRings} championships!");
            // }
            //////
            // int numRings = 5;
            // int numOfAllStarAppearances = 17;
            // if (numRings >= 5 || numOfAllStarAppearances > 3)
            // {
            // Console.WriteLine("Welcome, you are truly a legend");
            // }

            /////
            // bool crazy = false;//change here for no writeline
            // if (!crazy)
            // {
            //     Console.WriteLine("Let's party!");
            // }

            ///FOR LOOPS
            // loop from 1 to 5 including 5
            // for (int i = 1; i <= 5; i++)
            // {
            //     Console.WriteLine(i);
            // }
            // // loop from 1 to 5 excluding 5
            // for (int i = 1; i < 5; i++)
            // {
            //     Console.WriteLine(i);
            // }
            //LOOPS WITH VARIABLES//
            // int start = 0;
            // int end = 5;
            // // loop from start to end including end
            // for (int i = start; i <= end; i++)
            // {
            //     Console.WriteLine(i);
            // }
            // // loop from start to end excluding end
            // for (int i = start; i < end; i++)
            // {
            //     Console.WriteLine(i);
            // }

            //WHILE LOOPS
            // for (int i = 1; i < 6; i = i + 1)
            // {
            //     Console.WriteLine(i);
            // }
            //
            // int i = 1;
            // while (i < 6)
            // {
            //     Console.WriteLine(i);
            //     i = i + 1;
            // }

            ////Random
            // Random rand = new Random();
            // for(int val = 0; val < 10; val++)
            // {
            //     //Prints the next random value between 2 and 8
            //     Console.WriteLine(rand.Next(2,8));
            // }
            // int start1 = 0;
            // int end1 = 101;
            ///////////
            // for (int i = 1; i < 101; i++){
            //     if(i % 5 ==0 && i % 3 ==0f){
            //         Console.WriteLine($"fizzbuzz");
            //     } else if  (i % 5 ==0) {
            //         Console.WriteLine($"fizz");
            //     } else if (i % 3 ==0){
            //         Console.WriteLine($"buzz");
            //     } else {
            //         Console.WriteLine(i);
            //     }
            // }
            int i = 1;
            while (i < 101)
            {
                Console.WriteLine(i);
                i = i + 1;
            
            if(i % 5 ==0 && i % 3 ==0f){
                    Console.WriteLine($"fizzbuzz");
                } else if  (i % 5 ==0) {
                    Console.WriteLine($"fizz");
                } else if (i % 3 ==0){
                    Console.WriteLine($"buzz");
                }
            }
        }
    }
}

