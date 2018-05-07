int rangeBitCount(int a, int b) {
if(0<=a && a<=b) {
        int total = 0;
        for (int i = a; i <= b; i++) {
            int t = i;
            while (t != 0) {
                if((t&1)==1)
                total++;
                t >>= 1;
            }
        }
 
        return total;
    }
    else
    {
        throw new ArgumentOutOfRangeException();
    }
}
