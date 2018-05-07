int absoluteValuesSumMinimization(int[] A) {
int smallest = int.MaxValue;
    int x = 0;
    foreach (int i in A)
    {
        if (A.Sum(t => Math.Abs(t - i)) >= smallest) continue;
        smallest = A.Sum(t => Math.Abs(t - i));
        x = i;
    }

    return x;
}
