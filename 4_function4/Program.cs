using System;

namespace _4_function4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int verticalCoordinatesCharacter = 2;
            int horizontalCoordinatesCharacter = 20;
            int verticalMovement = 0;
            int horizontalMovement = 1;
            bool canExitMethod = true;
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

            DrawMap(map);

            DrawCharacter(ref verticalCoordinatesCharacter, ref horizontalCoordinatesCharacter);

            while (canExitMethod)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();

                    ChangeDirection(key, ref verticalMovement, ref horizontalMovement);

                    if (map[verticalCoordinatesCharacter + verticalMovement, horizontalCoordinatesCharacter + horizontalMovement] != '#')
                    {
                        MakeMove(ref verticalCoordinatesCharacter, ref horizontalCoordinatesCharacter, ref verticalMovement, ref horizontalMovement);
                    }
                }
            }
        }

        static void MakeMove(ref int verticalCoordinatesCharacter, ref int horizontalCoordinatesCharacter, ref int verticalMovement, ref int horizontalMovement)
        {
            Console.SetCursorPosition(horizontalCoordinatesCharacter, verticalCoordinatesCharacter);
            Console.Write(" ");

            verticalCoordinatesCharacter += verticalMovement;
            horizontalCoordinatesCharacter += horizontalMovement;

            Console.SetCursorPosition(horizontalCoordinatesCharacter, verticalCoordinatesCharacter);
            Console.Write('@');
        }

        static void ChangeDirection(ConsoleKeyInfo key, ref int verticalMovement, ref int horizontalMovement)
        {
            switch (key.Key)
            {
                case ConsoleKey.UpArrow:
                    verticalMovement = -1;
                    horizontalMovement = 0;
                    break;
                case ConsoleKey.DownArrow:
                    verticalMovement = 1;
                    horizontalMovement = 0;
                    break;
                case ConsoleKey.LeftArrow:
                    verticalMovement = 0;
                    horizontalMovement = -1;
                    break;
                case ConsoleKey.RightArrow:
                    verticalMovement = 0;
                    horizontalMovement = 1;
                    break;
            }
        }

        static void DrawCharacter(ref int verticalCoordinatesCharacter, ref int horizontalCoordinatesCharacter)
        {
            Console.CursorVisible = false;
            Console.SetCursorPosition(horizontalCoordinatesCharacter, verticalCoordinatesCharacter);
            Console.Write('@');
        }

        static void DrawMap(char[,] map)
        {
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    Console.Write(map[i, j]);
                }

                Console.WriteLine();
            }
        }
    }
}       
