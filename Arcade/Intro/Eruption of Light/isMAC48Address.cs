bool isMAC48Address(string inputString) {
return Regex.IsMatch(inputString, "^([0-9A-F]{2}-){5}[0-9A-F]{2}$");
}
