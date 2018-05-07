string decipher(string cipher) {
string result="";
    while(cipher.Length>0) {
        string s = cipher.Substring(0,2);
        int n = int.Parse(s);
        if(n>=97) {
            result+=(char)n;
            cipher = cipher.Substring(2);
        }else {
            s = cipher.Substring(0,3);
            n = int.Parse(s);
            result+=(char)n;
            cipher = cipher.Substring(3);
        }
    }
    return result;
}
