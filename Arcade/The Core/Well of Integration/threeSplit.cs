int threeSplit(int[] a) {
 var sum = 0;
    foreach (var num in a)
    {
        sum += num;
    }
    var temp = sum%3;
    
    if(temp != 0) 
    {
        return 0;
    }
    sum /= 3;
    var cut1 = 0; var cut2 = 0; var count = 0;
    var sum1 = 0; var sum2 = 0;
    for (cut1 = 0;cut1 <a.Length-2;cut1++)
    {
        sum1 += a[cut1];
        if(sum1 == sum) {
            sum2 = 0;
            for(cut2 = (cut1 + 1); cut2 <a.Length-1 ;cut2++)
            {
                sum2 += a[cut2];
                if(sum2 == sum) {
                    count += 1;
                }
            }
        }
    }
    return count;
}
