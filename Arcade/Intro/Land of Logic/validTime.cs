bool validTime(string time) {
 return Regex.IsMatch(time, "^([01]\\d|2[0-3]):([0-5]\\d)$");
}
