int addTwoDigits(int n) {
    int result = 0;
    if(n >= 10 && n <= 99)
    {

        result = n%10;
        if(n/10 > 0)
        {
result += n/10;            
        }
    }
    return result;

}
