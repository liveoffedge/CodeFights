string integerToStringOfFixedWidth(int number, int width) {
  StringBuilder result = new StringBuilder();
 
    for (int i = 0; i < width; i++) {
        result.Append("0");
    }
 
    int position = width - 1;
    while (number != 0 && position >= 0) {
        
        result[position] = (number % 10).ToString()[0];
        number /= 10;
        position--;
    }
 
    return result.ToString();
}
