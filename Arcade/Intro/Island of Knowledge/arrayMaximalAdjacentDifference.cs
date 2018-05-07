int arrayMaximalAdjacentDifference(int[] inputArray) {
    return inputArray.Take(inputArray.Length - 1).Select((a, i) => Math.Abs(inputArray[i + 1] - a)).Max();
}
