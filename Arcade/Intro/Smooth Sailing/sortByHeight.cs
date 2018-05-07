int[] sortByHeight(int[] a) {
int[] res = a.Where(i => i != -1).ToArray<int>().OrderBy(i => i).ToArray<int>();
            int[] aa = new int[a.Length];
            int pos = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == -1)
                {
                    aa[i] = a[i];
                }
                else
                {
                    aa[i] = res[pos++];
                }
            }

            return aa;
}
