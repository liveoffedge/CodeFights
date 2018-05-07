int[][] spiralNumbers(int n) {
 var answer = new int[n][];
    for (var i = 0; i < n; i++)
        answer[i] = new int[n];

    var j = 1;
    var start = 0;
    var row = start;
    var col = start;
    var end = n - 1;
    while (j <= n * n)
    {
        // Horizontal to the right
        while (true)
        {
            if (answer[row][col] == 0)
            {
                answer[row][col] = j;
                j++;
            }
            if (col == end)
                break;

            col++;
        }
        // Vertically down
        while (true)
        {
            if (answer[row][col] == 0)
            {
                answer[row][col] = j;
                j++;
            }
            if (row == end)
                break;

            row++;
        }
        // Horizontal to the left
        while (true)
        {
            if (answer[row][col] == 0)
            {
                answer[row][col] = j;
                j++;
            }
            if (col == start)
                break;

            col--;
        }
        // Vertically up
        while (true)
        {
            if (answer[row][col] == 0)
            {
                answer[row][col] = j;
                j++;
            }
            if (row == start)
                break;

            row--;
        }
        row++;
        start++;
        end--;
    }
    return answer;
}
