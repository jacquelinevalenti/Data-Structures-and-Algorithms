using System;

namespace MineSweeper
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] bombs1 = { { 0, 2 }, { 2, 0 } };
            // mineSweeper(bombs1, 3, 3) should return:
            // [[0, 1, -1],
            //  [1, 2, 1],
            //  [-1, 1, 0]]

            int[,] bombs2 = { { 0, 0 }, { 0, 1 }, { 1, 2 } };
            // mineSweeper(bombs2, 3, 4) should return:
            // [[-1, -1, 2, 1],
            //  [2, 3, -1, 1],
            //  [0, 1, 1, 1]]

            int[,] bombs3 = { { 1, 1 }, { 1, 2 }, { 2, 2 }, { 4, 3 } };
            // mineSweeper(bombs3, 5, 5) should return:
            // [[1, 2, 2, 1, 0],
            //  [1, -1, -1, 2, 0],
            //  [1, 3, -1, 2, 0],
            //  [0, 1, 2, 2, 1],
            //  [0, 0, 1, -1, 1]]

            int[,] field1 = {{0, 0, 0, 0, 0},
                          {0, 1, 1, 1, 0},
                          {0, 1, -1, 1, 0}};

            // click(field1, 3, 5, 2, 2) should return:
            // [[0, 0, 0, 0, 0],
            //  [0, 1, 1, 1, 0],
            //  [0, 1, -1, 1, 0]]

            // click(field1, 3, 5, 1, 4) should return:
            // [[-2, -2, -2, -2, -2],
            //  [-2, 1, 1, 1, -2],
            //  [-2, 1, -1, 1, -2]]


            int[,] field2 = {{-1, 1, 0, 0},
                          {1, 1, 0, 0},
                          {0, 0, 1, 1},
                          {0, 0, 1, -1}};

            // click(field2, 4, 4, 0, 1) should return:
            // [[-1, 1, 0, 0],
            //  [1, 1, 0, 0],
            //  [0, 0, 1, 1],
            //  [0, 0, 1, -1]]

            // click(field2, 4, 4, 1, 3) should return:
            // [[-1, 1, -2, -2],
            //  [1, 1, -2, -2],
            //  [-2, -2, 1, 1],
            //  [-2, -2, 1, -1]]

            int[,] result1 = MineSweeper(bombs1, 3, 3);
            int[,] result2 = MineSweeper(bombs2, 3, 4);
            int[,] result3 = MineSweeper(bombs3, 5, 5);

            Print2DArray(result1);
            Console.WriteLine();
            Print2DArray(result2);
            Console.WriteLine();
            Print2DArray(result3);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            int[,] clickresult1 = Click(field1, 3, 5, 2, 2);
            Print2DArray(clickresult1);
            Console.WriteLine();
            int[,] clickresult2 = Click(field1, 3, 5, 1, 4);
            Print2DArray(clickresult2);
            Console.WriteLine();
            int[,] clickresult3 = Click(field2, 4, 4, 0, 1);
            Print2DArray(clickresult3);
            Console.WriteLine();
            int[,] clickresult4 = Click(field2, 4, 4, 1, 3);
            Print2DArray(clickresult4);
            

        }

        // no duplicates in bombs
        // bombs represented as -1
        // surrounding numbers have to indicate how many bombs are around that location
        public static int[,] MineSweeper(int[,] bombs, int numRows, int numCols)
        {
            // create the resulting 2D array with size numRows x numCols
            int[,] field = new int[numRows, numCols];
            // initialize bomb locations in field
            for (int b = 0; b < (bombs.Length / 2); b++)
            {
                int rowIndex = bombs[b, 0];
                int colIndex = bombs[b, 1];
                // bomb located at row i and column i
                field[rowIndex, colIndex] = -1;

                // outside loop iterates from row i - 1 to row i + 1
                // inside loop iterates from column i - 1 to column i + 1
                for (int i = rowIndex - 1; i < rowIndex + 2; i++)
                {
                    for (int j = colIndex - 1; j < colIndex + 2; j++)
                    {
                        if (0 <= i && i < numRows && 0 <= j && j < numCols && field[i,j] != -1)
                        {
                            // add 1 to surrounding squares (9 surrounding cells)
                            field[i,j] += 1;
                        }
                    }
                }
            }
            return field;
        }

        // method to print out the array in a nice visual way
        public static void Print2DArray(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"[{matrix[i, j]}]");
                }
                Console.WriteLine();
            }
        }

        public static int[,] Click(int[,] field, int numRows, int numCols, int givenI, int givenJ)
        {
            // check if user's "click" was a cell with 0 in it
            if (field[givenI, givenJ] == 0)
            {
                // reassign clicked cell
                field[givenI, givenJ] = -2;
                // loop through 
                for (int i = givenI - 1; i < givenI + 2; i++)
                {
                    for (int j = givenJ - 1; j < givenJ + 2; j++)
                    {
                        if (0 <= i && i < numRows && 0 <= j && j < numCols && field[i, j] == 0)
                        {
                            // alter 9 squares around clicked cell if they are equal to zero
                            field[i, j] = -2;
                        }
                    }
                }
            }
            return field;
        }

    }

}

