while (true)
{
    int x = Convert.ToInt32(Console.ReadLine());
    int[,] matrix = new int[x, x];
    if (x <= 100)
    {
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < x; j++)
            {
                matrix[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }


        bool isMatrixSymmetric(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (matrix[i, j] != matrix[j, i])
                    {
                        return false;
                    }
                }

            }
            return true;
        }
        Console.Clear();
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < x; j++)
            {
                Console.Write($" {matrix[i, j]}");
            }
            Console.WriteLine();
        }

        if (isMatrixSymmetric(matrix))
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }
        break;
    }
    else
    {
        Console.WriteLine("х должен быть меньше 100");
    }
}