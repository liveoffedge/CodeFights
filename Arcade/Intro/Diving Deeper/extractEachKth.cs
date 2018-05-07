int[] extractEachKth(int[] inputArray, int k) {
return inputArray.Where((i, i1) => i1 % k != k - 1).ToArray();
}
