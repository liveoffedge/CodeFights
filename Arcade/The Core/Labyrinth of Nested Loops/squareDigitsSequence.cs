int squareDigitsSequence(int a0) {
int cur = a0;
    List<int> was = new List<int>();
 
    while (!was.Contains(cur)) {
        was.Add(cur);
        int next = 0;
        while (cur > 0) {
            next += (cur % 10) * (cur % 10);
            cur /= 10;
        }
        cur = next;
    }
 
    return was.Count + 1;
}
