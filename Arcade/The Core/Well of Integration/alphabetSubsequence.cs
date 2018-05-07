bool alphabetSubsequence(string s) {
 char prev = (char)1;
    foreach(char x in s) {
        if(x<=prev)
            return false;
        prev = x;
    }
    return true;
}
