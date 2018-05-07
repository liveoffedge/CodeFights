int lateRide(int n) {
int timeHh = 0;
    int timeMm = 0;
    if(n%60 == 0)
{
    timeHh = n/60;
}else
{
    if(n> 0 && n < 60)
    {
        timeHh = 0;  
        timeMm = n;
    }
    else
    {
        timeHh = n/60;
        timeMm = n - (timeHh*60);
    }
}
    int sum = 0;
    if(timeHh>9)
    {
     sum = timeHh%10 + timeHh/10;        
    }
        else
        {
sum = timeHh;            
        }
    
    if(timeMm>9)
    {
     sum += (timeMm%10 + timeMm/10);        
    }
        else
        {
sum += timeMm;            
        }
   
    return sum;
}
