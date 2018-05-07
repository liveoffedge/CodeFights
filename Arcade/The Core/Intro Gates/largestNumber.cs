int largestNumber(int n) {
    int result = 0;
    for(int i = 0;i<n;i++)
    {
        result = result*10 + 9;
    }
return result;
}
