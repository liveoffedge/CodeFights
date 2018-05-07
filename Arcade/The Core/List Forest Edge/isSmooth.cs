bool isSmooth(int[] arr) {
    int len = arr.Length;
    if(len > 1)
    {
        int first = arr[0];
        int last = arr[len-1];
        if(first == last)
        {
            int middleNum = 0;
            if(len%2==0)
            {
                middleNum = arr[len/2] + arr[len/2 -1];
            }
            else
            {
                middleNum = arr[len/2];
            }
            if(middleNum == first)
                return true;
            else
                return false;
                }
        else
        {
             return false;   
        }
    }
    else
    {
        return false;
    }   
}
