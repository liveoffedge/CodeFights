int[][] minesweeper(bool[][] matrix) {
int rows = matrix.Length;
    int columns = matrix[0].Length;
    int[][] solution = new int[rows][];
    for (var index = 0; index < solution.Length; index++)
        solution[index] = new int[columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
        {
            int count = 0;
            if (i - 1 >= 0)
            {
                if (j - 1 >= 0)
                    if (matrix[i - 1][j - 1])
                        count++;
                if (j + 1 >= 0 & j + 1 < columns)
                    if (matrix[i - 1][j + 1])
                        count++;
                if (matrix[i - 1][j])
                    count++;
            }

            if (i + 1 >= 0 && i + 1 < rows)
            {
                if (j - 1 >= 0)
                    if (matrix[i + 1][j - 1])
                        count++;
                if (j + 1 >= 0 & j + 1 < columns)
                    if (matrix[i + 1][j + 1])
                        count++;
                if (matrix[i + 1][j])
                    count++;
            }

            if (j - 1 >= 0)
                if (matrix[i][j - 1])
                    count++;
            if (j + 1 >= 0 & j + 1 < columns)
                if (matrix[i][j + 1])
                    count++;

            solution[i][j] = count;
        }

    return solution;
}
