int[] concatenateArrays(int[] a, int[] b) {
    List<int> result = new List<int>();
    for(int i = 0; i < a.Length; i++)
    {
        result.Add(a[i]);
    }
    for(int i = 0; i < b.Length; i++)
    {
        result.Add(b[i]);
    }
    return result.ToArray();
}
