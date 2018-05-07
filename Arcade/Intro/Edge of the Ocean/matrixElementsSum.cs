int matrixElementsSum(int[][] matrix) {
int sum = 0;
    int rows = matrix.GetLength(0);
    int columns = matrix[0].Length;
    for (int x = 0; x < columns; x++)
        for (int y = 0; y < rows; y++)
        {
            if (matrix[y][x] == 0)
                break;

            sum += matrix[y][x];
        }

    return sum;
}
