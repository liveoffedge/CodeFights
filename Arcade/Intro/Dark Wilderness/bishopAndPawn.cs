bool bishopAndPawn(string bishop, string pawn) {
return Math.Abs(bishop[1] - pawn[1]).Equals(Math.Abs(bishop[0] - pawn[0]));
}
