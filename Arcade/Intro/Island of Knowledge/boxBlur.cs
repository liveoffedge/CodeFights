int[][] boxBlur(int[][] image) {
int rows = image.Length;
    int columns = image[0].Length;
    int[][] solution = new int[rows - 2][];
    for (int index = 0; index < solution.Length; index++)
        solution[index] = new int[columns - 2];

    for (int i = 0; i < rows - 2; i++)
        for (int j = 0; j < columns - 2; j++)
            solution[i][j] = (image[i][j] + image[i][j + 1] + image[i][j + 2] + image[i + 1][j] + image[i + 1][j + 1] + image[i + 1][j + 2] + image[i + 2][j] + image[i + 2][j + 1] + image[i + 2][j + 2]) / 9;

    return solution;
}
