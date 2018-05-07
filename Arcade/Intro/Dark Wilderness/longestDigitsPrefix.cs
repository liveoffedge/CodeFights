string longestDigitsPrefix(string inputString) {
 return Regex.Match(inputString, "^\\d+").Value;
}
