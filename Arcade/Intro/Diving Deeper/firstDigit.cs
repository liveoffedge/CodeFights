char firstDigit(string inputString) {
 return Regex.Match(inputString, "\\d{1}").Value[0];
}
