int[] replaceMiddle(int[] arr) {
    int len = arr.Length;
    if(len>1)
    {
        int middleNum =0;
        if(len%2==0)
        {
            List<int> result = new List<int>();
            middleNum = arr[len/2 - 1] + arr[len/2];
            
            for(int i=0;i<len/2-1;i++)
            {
                result.Add(arr[i]);
            }
            result.Add(middleNum);
            for(int i=len/2 + 1;i<len;i++)
            {
                result.Add(arr[i]);
            }
            return result.ToArray();
        }
        else
        {
            return arr;
        }
    }
    else
        return arr;   
}
