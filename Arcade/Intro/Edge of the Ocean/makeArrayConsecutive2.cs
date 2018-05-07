int makeArrayConsecutive2(int[] statues) {
    Array.Sort(statues);
    int result = 0;
    for(int i =0;i<statues.Length-1;i++)
    {
        if((statues[i+1] - statues[i]) > 1)
            result += ((statues[i+1] - statues[i])-1);
    }
    return result;
}
