int commonCharacterCount(string s1, string s2) {
    return s1.ToCharArray().Distinct().Sum(c => Math.Min(s1.Count(x => x == c), s2.Count(x => x == c)));
}
