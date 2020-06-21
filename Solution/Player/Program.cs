﻿using System;

namespace Player
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();

            player.Play();
            (player as IPlayable).Stop();

            player.Record();
            (player as IRecodable).Stop();

            Console.ReadKey();
        }
    }
}
