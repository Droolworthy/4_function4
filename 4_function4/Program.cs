using System;

namespace _4_function4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int verticalMovement = 2;
            int horizontalMovement = 20;
            bool canExitMethod = true;
            Console.CursorVisible = false;
            char[,] map = {
                { '#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#'},
                { '#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
                { '#',' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ','#','#','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#','#','#',' ',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ','#'},
                { '#',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ','#','#','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#','#','#',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ','#'},
                { '#',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ','#','#','#',' ',' ',' ',' ','#','#',' ',' ',' ',' ','#','#','#',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ','#'},
                { '#',' ',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ','#'},
                { '#',' ',' ',' ',' ',' ',' ',' ','#',' ',' ','#','#','#','#','#','#','#',' ',' ','#','#',' ',' ','#','#','#','#','#','#','#',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ','#'},
                { '#',' ',' ',' ',' ',' ',' ',' ',' ','#',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
                { '#',' ',' ',' ',' ',' ',' ',' ',' ',' ','#','#',' ',' ','#','#','#','#','#','#','#','#','#','#','#','#','#','#',' ',' ','#','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
                { '#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#',' ',' ','#','#','#','#','#','#','#','#','#','#','#','#',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
                { '#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
                { '#',' ',' ',' ',' ',' ',' ',' ','#','#',' ',' ',' ','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#',' ',' ',' ','#','#',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
                { '#',' ',' ',' ',' ',' ',' ','#','#','#','#','#','#','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#','#','#','#','#','#','#',' ',' ',' ',' ',' ',' ',' ',' ','#'},
                { '#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
                { '#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#'},
            };

            while (canExitMethod)
            {

                for (int i = 0; i < map.GetLength(0); i++)
                {
                    for (int j = 0; j < map.GetLength(1); j++)
                    {
                        Console.Write(map[i, j]);
                    }

                    Console.WriteLine();
                }
                Character(ref horizontalMovement, ref verticalMovement);

                ConsoleKeyInfo charKey = Console.ReadKey();

                switch (charKey.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (map[verticalMovement - 1, horizontalMovement] != '#')
                        {
                            verticalMovement--;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (map[verticalMovement + 1, horizontalMovement] != '#')
                        {
                            verticalMovement++;
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                        if (map[verticalMovement, horizontalMovement - 1] != '#')
                        {
                            horizontalMovement--;
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        if (map[verticalMovement, horizontalMovement + 1] != '#')
                        {
                            horizontalMovement++;
                        }
                        break;
                }

                Console.Clear();
            }

            СharacterЬovement(ref map, ref verticalMovement, ref horizontalMovement);
        }

        static void СharacterЬovement(ref char[,] map, ref int verticalMovement, ref int horizontalMovement)
        {
            ConsoleKeyInfo charKey = Console.ReadKey();

            switch (charKey.Key)
            {
                case ConsoleKey.UpArrow:
                    if (map[verticalMovement - 1, horizontalMovement] != '#')
                    {
                        verticalMovement--;
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (map[verticalMovement + 1, horizontalMovement] != '#')
                    {
                        verticalMovement++;
                    }
                    break;
                case ConsoleKey.LeftArrow:
                    if (map[verticalMovement, horizontalMovement - 1] != '#')
                    {
                        horizontalMovement--;
                    }
                    break;
                case ConsoleKey.RightArrow:
                    if (map[verticalMovement, horizontalMovement + 1] != '#')
                    {
                        horizontalMovement++;
                    }
                    break;
            }

            Console.Clear();
        }

        static void Character(ref int horizontalMovement, ref int verticalMovement)
        {
            Console.SetCursorPosition(horizontalMovement, verticalMovement);
            Console.Write('@');
        }
    }
}
