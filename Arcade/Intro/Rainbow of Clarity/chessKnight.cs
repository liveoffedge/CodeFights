int chessKnight(string cell) {
var possible_moves = new List<string>();

    // Upward
    if (int.Parse(cell[1].ToString()) + 2 <= 8)
    {
        if (cell[0] >= 'b')
            possible_moves.Add((char)(cell[0] - 1) + ((char) (cell[1] + 2)).ToString());

        if (cell[0] <= 'g')
            possible_moves.Add((char)(cell[0] + 1) + ((char)(cell[1] + 2)).ToString());
    }

    // Rightward
    if (cell[0] <= 'f')
    {
        if (int.Parse(cell[1].ToString()) <= 7)
            possible_moves.Add((char)(cell[0] + 2) + ((char)(cell[1] + 1)).ToString());

        if (int.Parse(cell[1].ToString()) >= 2)
            possible_moves.Add((char)(cell[0] + 2) + ((char)(cell[1] - 1)).ToString());
    }

    // Downward
    if (int.Parse(cell[1].ToString()) - 2 >= 1)
    {
        if (cell[0] >= 'b')
            possible_moves.Add((char)(cell[0] - 1) + ((char)(cell[1] - 2)).ToString());

        if (cell[0] <= 'g')
            possible_moves.Add((char)(cell[0] + 1) + ((char)(cell[1] - 2)).ToString());
    }

    // Leftward
    if (cell[0] >= 'c')
    {
        if (int.Parse(cell[1].ToString()) <= 7)
            possible_moves.Add((char)(cell[0] - 2) + ((char)(cell[1] + 1)).ToString());

        if (int.Parse(cell[1].ToString()) >= 2)
            possible_moves.Add((char)(cell[0] - 2) + ((char)(cell[1] - 1)).ToString());
    }

    return possible_moves.Count;
}
