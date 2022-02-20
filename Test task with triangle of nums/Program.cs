using System;

namespace Test_task_with_triangle_of_nums
{
    class Program
    {
        static Random rand = new Random();
        static void Main(string[] args)
        {
            const int LEVELS = 5;

            int[][] pyramid = new int[LEVELS][];

            for (int i = 0; i < LEVELS; i++)
            {
                pyramid[i] = new int[i + 1];

                for (int k = 0; k < pyramid[i].Length; k++)
                {
                    pyramid[i][k] = rand.Next(0, 100);
                }
            }

            Console.WriteLine("The Great Pyramid: \n");
            Console.ForegroundColor = ConsoleColor.Yellow;

            for (int i = 0; i < pyramid.GetLength(0); i++)
            {
                for (int k = 0; k < pyramid[i].GetLength(0); k++)
                {
                    Console.Write(pyramid[i][k] + "\t");

                }
                Console.WriteLine();
            }

            Console.ForegroundColor = ConsoleColor.Magenta;

            int sum = PathSum(pyramid, 0, 0);

            Console.WriteLine($"\nMax sum will be = {sum}");

            Console.ReadKey();
        }

        
        /// <summary>
        /// Этот метод считает максимальную сумму узлов пирамиды.
        /// </summary>
        /// <param name="pyramid">Зубчатый массив с [Уровни][Позиция].</param>
        /// <param name="position">Уровень пирамиды.</param>
        /// <param name="level">Позиция на уровне.</param>
        /// <returns>Максимальная сумма пути.</returns>

        public static int PathSum(int[][] pyramid, int position, int level)
        {

            if (level == pyramid.GetLength(0) - 1)
            {
                return pyramid[level][position];
            }

            return pyramid[level][position] + Math.Max(PathSum(pyramid, position, level + 1), PathSum(pyramid, position + 1, level + 1));


        }

    }
}
