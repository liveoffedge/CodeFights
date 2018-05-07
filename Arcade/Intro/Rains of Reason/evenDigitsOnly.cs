bool evenDigitsOnly(int n) {
 return n.ToString().All(c => int.Parse(c.ToString()) % 2 == 0);
}
