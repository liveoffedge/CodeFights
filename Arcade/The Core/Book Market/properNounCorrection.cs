string properNounCorrection(string noun) {
    return  char.ToUpper(noun[0]) + noun.Substring(1).ToLower();
}
