int[] alternatingSums(int[] a) {
    int aa = 0;
    int b = 0;
    for(int i = 0;i<a.Length;i++)
    {
       if(i % 2 == 0) 
       {
        aa = aa + a[i]   ;
       }
        else
        {
            b = b + a[i]   ;
        }
    }
    
    return new int[2]{aa,b};

}
