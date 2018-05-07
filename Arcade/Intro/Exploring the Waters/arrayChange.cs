int arrayChange(int[] inputArray) {
int change = 0;
    for (int i = 0; i < inputArray.Length - 1; i++)
        while (inputArray[i] >= inputArray[i + 1])
        {
            inputArray[i + 1]++;
            change++;
        }

    return change;
}
