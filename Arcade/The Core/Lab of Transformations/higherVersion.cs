bool higherVersion(string ver1, string ver2) {
string[] s1 = ver1.Split('.');
    string[] s2 = ver2.Split('.');
    for(int i=0;i<Math.Min(s1.Length,s2.Length);i++) {
        if(int.Parse(s1[i])>int.Parse(s2[i]))
            return true;
        else if(int.Parse(s1[i])<int.Parse(s2[i]))
            return false;
    }
    return false;
}
