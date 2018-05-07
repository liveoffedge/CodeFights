int firstDuplicate(int[] a) {
    
  if (a.Length <= 1) return -1;
            for (int i = 0; i < a.Length; i++)
            {
                int pos = Math.Abs(a[i]) - 1;
                if (a[pos] < 0) return pos + 1;
                else a[pos] = -a[pos];
            }
            return -1;
}
