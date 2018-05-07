int timedReading(int maxLength, string text) {
string[] words = text.Split(' ');
    int count=0;
    if(words.Length==0)
        words[0]=text;
    foreach(string word in words) {
        Regex r = new Regex("(?:[^a-zA-Z ]|(?<=[.'\"])s)", 
            RegexOptions.IgnoreCase | 
            RegexOptions.CultureInvariant |
            RegexOptions.Compiled);
        string trimmedWord =r.Replace(word, String.Empty);
         
        if(trimmedWord.Length<=maxLength && trimmedWord.Length>0)
            count++;
    }
    return count;
}
