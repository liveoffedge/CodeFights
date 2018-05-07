int sumUpNumbers(string inputString) {
    return Regex.Matches(inputString, "\\d+").Cast<Match>().Sum(match => int.Parse(match.Value));
}
