int cyclicString(string s) {
 for (int i = 1;i<=s.Length;i++) {
        string part = s.Substring(0,i);
        bool isRoot = true;
        for (int j = 0;j<s.Length;j++) {
            if (s[j] != part[j % part.Length]) {
                isRoot = false;
                break;
            }
        }
        if (isRoot) {
            return i;
        }
    }
    return 0;
}
