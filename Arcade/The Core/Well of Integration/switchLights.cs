int[] switchLights(int[] a) {
 for (int i = 0; i < a.Length; i++) {
        if (a[i] == 1) {
            for (int j = 0; j <= i; j++) {
                a[j] = 1 - a[j];
            }
        }
    }
    return a;
}
