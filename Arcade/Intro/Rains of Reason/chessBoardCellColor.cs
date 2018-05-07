bool chessBoardCellColor(string cell1, string cell2) {
 return (cell1[0] - 'A' % 2 + cell1[1] - '1' % 2) % 2 == (cell2[0] - 'A' % 2 + cell2[1] - '1' % 2) % 2;
}
