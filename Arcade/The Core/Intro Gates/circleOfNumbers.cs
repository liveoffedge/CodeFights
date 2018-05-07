int circleOfNumbers(int n, int firstNumber) {
int num = n/2;
    for(int i= 0;i<num;i++)
    {
        firstNumber++;
        if(firstNumber >= n)
        {
firstNumber =0;            
        }
    }
    return firstNumber;
}
