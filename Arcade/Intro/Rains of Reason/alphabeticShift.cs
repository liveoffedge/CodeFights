string alphabeticShift(string inputString) {
return new string(inputString.ToCharArray().Select(x => x == 'z' ? 'a' : (char)(x + 1)).ToArray());
}
