int[] arrayPreviousLess(int[] items) {
List<int> result = new List<int>();
    for (int i = 0; i < items.Length; i++) {
        int substitute = -1;
        for (int j = 0; j < i; j++) {
            if (items[j] < items[i]) {
                substitute = items[j] ;
            }
        }
        result.Add(substitute);
    } 
    return result.ToArray();
}
