bool arithmeticExpression(int A, int B, int C) {
    if((A + B) == C) 
    {
        Console.Write("+");
        return true;
    }
    if((A - B) == C) 
    {
        Console.Write("-");
        return true;
    }
    if((A * B) == C) 
    {
        Console.Write("*");
        return true;
    }
    if(((float)A / (float)B) == C)
    {
        Console.Write("/");
        return true;
    }
    return false;    
}
