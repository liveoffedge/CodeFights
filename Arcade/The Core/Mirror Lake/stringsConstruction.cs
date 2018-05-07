int stringsConstruction(string A, string B) {
 int count = 0;
            string A1 = A;
            string B1 = B;
            while (B1.Length >= A1.Length)
            {
                string str = "";
                foreach (var item in A1)
                {
                    int i = B1.IndexOf(item);
                    if (i != -1)
                    {
                        B1 = B1.Remove(i, 1);
                        str += item;
                    }
                }
                if (str == A1)
                {
                    count++;
                }
                else
                {
                    break;
                }



            }
            return count;
}
