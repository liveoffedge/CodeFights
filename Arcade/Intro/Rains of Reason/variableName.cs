bool variableName(string name) {
 if (Regex.IsMatch(name, "^\\d"))
        return false;
    if (name.All(c => ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z')) || char.IsDigit(c) || c == '_'))
        return true;

    return false;
}
