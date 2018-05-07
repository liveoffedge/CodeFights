int[] metroCard(int lastNumberOfDays) {    
if(lastNumberOfDays == 31)
{int[] result = new int[3];
    result[0] = 28;
    result[1] = 30;
    result[2] = 31;
 return result;
}    
 if(lastNumberOfDays == 30)
{
    int[] result = new int[1];    
    result[0] = 31;    
    return result;
}    
 if(lastNumberOfDays == 28)
{
    int[] result = new int[1];
    result[0] = 31;
    return result;
}
return new int[0];
}
