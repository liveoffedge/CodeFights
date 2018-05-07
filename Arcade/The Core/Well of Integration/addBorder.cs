string[] addBorder(string[] picture) {
List<string> answer = new List<string>();
    string decoratedRow =string.Empty;
    for (var i = 0; i < picture[0].Length + 2; i++) {
        decoratedRow += "*";
    }
    answer.Add(decoratedRow);
    for (var i = 0; i < picture.Length; i++) {
        string row = "*";
        for (var j = 0; j < picture[0].Length; j++) {
          row += picture[i][j];
        }
        row += "*";
        answer.Add(row);
      }
      answer.Add(decoratedRow);
      return answer.ToArray();
}
