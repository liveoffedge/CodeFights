string cipher26(string message) {
string result = string.Empty;
    int sub=0,prev=0;
    for(int i=0;i<message.Length;i++) {
        int t = message[i]-97;
        sub = t -prev;
        if(sub<0)
            sub=sub+26;
        result+=(char)(sub+97);
        prev = t;
    }
    return result;
}
