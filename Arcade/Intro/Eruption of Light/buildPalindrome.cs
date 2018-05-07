string buildPalindrome(string st) {
var i = 0;
    while (!st.Substring(i).ToArray().SequenceEqual(st.Substring(i).Reverse().ToArray()) && i < st.Length)
        i++;

    return st + new string(st.Substring(0, i).Reverse().ToArray());
}
