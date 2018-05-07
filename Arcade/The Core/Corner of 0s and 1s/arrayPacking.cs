int arrayPacking(int[] a) {
if(1 <= a.Length && a.Length <= 4) {
        int result = 0;
        for(int index=0;index<a.Length;index++) {
            if(a[index]>256 || a[index]<0) {
                throw new ArgumentOutOfRangeException();
            }
            else {
                result += a[index] << 8 * index;
            }
        }
        return result;
    }
    else {
        throw new ArgumentOutOfRangeException();
    }
}
