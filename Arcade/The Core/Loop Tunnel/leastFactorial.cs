int leastFactorial(int n) {
    int result = 1;
    for(int i = 1;i<=n;i++)
    {
        result *= i;
        if(result >= n)
            return result;
    }
    return n;
}
