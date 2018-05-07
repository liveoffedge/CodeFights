int deleteDigit(int n) {
return int.Parse(n.ToString().Select((c, i) => n.ToString().Remove(i, 1)).Max());
}
