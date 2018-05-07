int[] arrayReplace(int[] inputArray, int elemToReplace, int substitutionElem) {
 return inputArray.Select(i => i == elemToReplace ? substitutionElem : i).ToArray();
}
