bool isMAC48Address(string inputString) {
 Regex r = new Regex("^([0-9A-Fa-f]{2}[:-]){5}([0-9A-Fa-f]{2})$");
  return (r.IsMatch(inputString));   
}
