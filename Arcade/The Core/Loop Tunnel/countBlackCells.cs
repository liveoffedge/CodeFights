int countBlackCells(int n, int m) {
    return n + m + GCD(n, m) - 2;
}
static int GCD(int a, int b)
{
    return b == 0 ? a : GCD(b, a % b);
}
