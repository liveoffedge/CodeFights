int[] firstReverseTry(int[] arr) {
    int len = arr.Length;
    if(len>1)
    {
        int first = arr[0];
        int last = arr[len-1];
        arr[0] = last;
        arr[len-1] = first;
    }
    return arr;
}
