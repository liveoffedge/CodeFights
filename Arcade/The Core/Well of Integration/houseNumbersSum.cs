int houseNumbersSum(int[] inputArray) {
if(5 <= inputArray.Length && inputArray.Length <= 10) {
        int sum = 0;
        for(int i=0;i<inputArray.Length;i++) {
            int aItem = inputArray[i];
            if(aItem>10 || aItem<0)
                throw new ArgumentOutOfRangeException();
            if(aItem!=0) {
                sum+=aItem;
            }
            else break;
        }
        return sum;
    }
    else {
        throw new ArgumentOutOfRangeException();
    }
}
