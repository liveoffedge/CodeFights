int avoidObstacles(int[] inputArray) {
for (int i = 2; ; i++)
        if (!inputArray.Any(x => x % i == 0))
            return i;
}
