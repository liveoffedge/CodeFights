string findEmailDomain(string address) {
 return Regex.Match(address, "@[A-z0-9\\.-]+$").Value.Substring(1);
}
