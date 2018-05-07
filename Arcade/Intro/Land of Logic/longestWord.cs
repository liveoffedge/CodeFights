string longestWord(string text) {
    var list = (from Match match in Regex.Matches(text, "[A-Za-z]+") select match.Value).ToList();
    return list.First(s => s.Length == list.Select(s1 => s1.Length).Max());
}
