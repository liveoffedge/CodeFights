int phoneCall(int min1, int min2_10, int min11, int s) {
    int mins = 0;
    int remains = 0;    
    if(s-min1 >= 0)
    {
        mins = 1;
        remains = s-min1;
        for(int i=1;i<10;i++)
        {
            if(remains >= min2_10)
            {
                mins++;
                remains = remains - min2_10;
            }
            else
            {
                remains = 0;
                break;
            }
        }        
        if(remains>=min11)
        {
            mins += remains/min11; 
        }        
    }
    else
    {
        mins = 0;
    }
    return mins;
}
