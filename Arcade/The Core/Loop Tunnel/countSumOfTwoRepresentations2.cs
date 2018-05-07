int countSumOfTwoRepresentations2(int n, int l, int r) {    
    int result = 0;
    for(int i = l;i<=r;i++)
    {
        if( (n-i) >= i && (n-i) <= r )
        result++;       
    }
return result;
}
