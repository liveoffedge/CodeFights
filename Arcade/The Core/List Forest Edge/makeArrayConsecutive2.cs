int makeArrayConsecutive2(int[] statues) {
    int min = statues[0];
    int max = 0;
    for(int i = 0;i<statues.Length;i++)
    {
        if(min > statues[i])
        {
           min = statues[i]; 
        }  
        if(max < statues[i])
        {
            max = statues[i];
        }
    }
    int result = 0;
    Console.WriteLine(max);
    Console.WriteLine(min);
    for(int i = min;i<=max;i++)
    {
        if(Array.IndexOf(statues, i) == -1)
        {
            result++;
        }
    }
    return result;
}
