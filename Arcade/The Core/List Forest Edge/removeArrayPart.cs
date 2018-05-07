int[] removeArrayPart(int[] inputArray, int l, int r) {
    List<int> result = new List<int>();
    for(int i=0;i<inputArray.Length;i++)
    {
        if(i >= l && i <= r)
        {
            ;
        }
        else
        {
            result.Add(inputArray[i]);
        }
    }
    return result.ToArray();
}
