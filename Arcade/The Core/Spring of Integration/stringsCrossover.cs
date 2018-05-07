int stringsCrossover(string[] inputArray, string result) {
int count = 0;
    for (int i = 0;i<inputArray.Length;i++) {
        for (int j = (i + 1);j<inputArray.Length;j++) {
            string chars1 = inputArray[i];
            string chars2 = inputArray[j];
            bool isCross = true;
            for (int k = 0;k<result.Length;k++) {
                if(result[k] != chars1[k] && result[k] != chars2[k]) {
                    isCross = false;
                    break;
                }
            }
            if (isCross) {
                count += 1;
            }
        }
    }
    return count;
}
