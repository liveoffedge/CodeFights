string lineEncoding(string s) {
var c = new char();
    var answer = string.Empty;
    var counter = 0;
    for (var i = 0; i < s.Length; i++)
    {
        if (c == '\0')
        {
            c = s[i];
            counter++;
        }
        else if (c == s[i])
        {
            counter++;
            if (i == s.Length - 1)
                answer += counter.ToString() + c;
        }
        else
        {
            if (counter > 1)
                answer += counter.ToString() + c;
            else
                answer += c;

            c = s[i];
            counter = 1;
            if (i == s.Length - 1)
                answer += c;
        }
    }

    return answer;
}
