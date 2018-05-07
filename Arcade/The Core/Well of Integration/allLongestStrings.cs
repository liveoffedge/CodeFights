string[] allLongestStrings(string[] inputArray) {
List<String> answer = new List<String>();
    answer.Add(inputArray[0]);
    for (int i = 1; i < inputArray.Length; i++) {
        if (inputArray[i].Length == answer[0].Length) {
            answer.Add(inputArray[i]);
        }
        if (inputArray[i].Length > answer[0].Length) {
            answer = new List<String>();
            answer.Add(inputArray[i]);
        }
    }
    return answer.ToArray();
}
