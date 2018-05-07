int differentSquares(int[][] matrix) {
 var two_x_two_s = new HashSet<Tuple<int, int, int, int>>();
    for (var row = 0; row < matrix.Length - 1; row++)
        for (var column = 0; column < matrix[0].Length - 1; column++)
            two_x_two_s.Add(new Tuple<int, int, int, int>(matrix[row][column], matrix[row][column + 1],
                matrix[row + 1][column], matrix[row + 1][column + 1]));

    return two_x_two_s.Count;
}
