bool checkPalindrome(string inputString) {
    for(int i = 0;i<inputString.Length;i++)
    {
        if(inputString[i] != inputString[inputString.Length - 1-i])
        {
            return false;
        }
    }
    return true;
}
