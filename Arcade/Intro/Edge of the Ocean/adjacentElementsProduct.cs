int adjacentElementsProduct(int[] inputArray) {
    int result = 0;
    result = inputArray[0] * inputArray[1];
    for(int i=1;i<inputArray.Length - 1;i++)
    {
        if(result < inputArray[i] * inputArray[i+1])
            result = inputArray[i] * inputArray[i+1];        
    }
    return result;
}
