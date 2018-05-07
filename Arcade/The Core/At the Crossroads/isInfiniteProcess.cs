bool isInfiniteProcess(int a, int b) {
    if(a==b)
        return false;
    if(a>b)
    {
        
        if((a-b)%2 ==0)
        {
            return true;
        }
        else
        {
            if((a%2 == 0 && b%2 == 0) || (a%2 == 1 && b%2 ==1))
            {
                return false;
            }
            else
                return true;
        }
    }
    else
    {
        if(b>a)
        {
            if(b-a == 2)
                return false;
            if((b-a)%2 ==0)
            {
                return false;
            }
            else
            {
                if((a%2 == 0 && b%2 == 0) || (a%2 == 1 && b%2 ==1))
                {
                    return false;
                }
                else
                    return true;
            }
        }
        else 
            return false;
    }
}
