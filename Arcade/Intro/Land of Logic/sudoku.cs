bool sudoku(int[][] grid) {
var horizontalLists = new List<List<int>>();
    var verticalLists = new List<List<int>>();
    var clustersLists = new List<List<int>>();
    for (var y = 0; y < 9; y++)
        verticalLists.Add(grid[y].ToList());

    for (var x = 0; x < 9; x++)
    {
        var horizontalList = new List<int>();
        for (var y = 0; y < 9; y++)
            horizontalList.Add(grid[y][x]);

        horizontalLists.Add(horizontalList);
    }

    for (var x = 0; x < 9; x += 3)
        for (var y = 0; y < 9; y += 3)
        {
            var clustersList = new List<int>();
            clustersList.Add(grid[y][x]);
            clustersList.Add(grid[y + 1][x]);
            clustersList.Add(grid[y + 2][x]);
            clustersList.Add(grid[y][x + 1]);
            clustersList.Add(grid[y + 1][x + 1]);
            clustersList.Add(grid[y + 2][x + 1]);
            clustersList.Add(grid[y][x + 2]);
            clustersList.Add(grid[y + 1][x + 2]);
            clustersList.Add(grid[y + 2][x + 2]);
            clustersLists.Add(clustersList);
        }

    return !horizontalLists.Any(
               horizontalList => horizontalList.Any(i => horizontalList.Count(i1 => i1 == i) != 1)) && !verticalLists.Any(
               verticalList => verticalList.Any(i => verticalList.Count(i1 => i1 == i) != 1)) && !clustersLists.Any(
               clustersList => clustersList.Any(i => clustersList.Count(i1 => i1 == i) != 1));
}
