using System;
using System.IO;

namespace _4_function4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int verticalMovement = 2;
            int horizontalMovement = 20;
            bool canExitMethod = true;          
            char[,] map = ReadMap("Map");
            
            while (canExitMethod)
            {
                DrawMap(map);

                DrawCharacter(ref horizontalMovement, ref verticalMovement);

                СontrolsMovementsCharacter(ref map, ref verticalMovement, ref horizontalMovement);
            }                                               
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

        static char[,] ReadMap(string mapName)
        {
            string[] newFile = File.ReadAllLines($"Map/{mapName}.txt");
            char[,] map = new char[newFile.Length, newFile[0].Length];

            for(int i = 0; i < map.GetLength(0); i++)
            {
                for(int j = 0; j < map.GetLength(1); j++)
                {
                    map[i,j] = newFile[i][j];
                }
            }

            return map;
        }

        static void СontrolsMovementsCharacter(ref char[,] map, ref int verticalMovement, ref int horizontalMovement)
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

        static void DrawCharacter(ref int horizontalMovement, ref int verticalMovement)
        {
            Console.CursorVisible = false;
            Console.SetCursorPosition(horizontalMovement, verticalMovement);
            Console.Write('@');
        }
    }
}
