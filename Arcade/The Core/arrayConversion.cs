int arrayConversion(int[] inputArray) {
 int i = 1;
            List<int> list1 = inputArray.ToList<int>();
            while (list1.Count != 1)
            {
                List<int> result;
                if (i % 2 == 0)
                {
                    //Product
                    result = Enumerable.Range(0, list1.Count / 2)
                          .Select(item => list1[item * 2] * list1[item * 2 + 1]).ToList<int>();
                }
                else
                {
                    //Add
                    result = Enumerable.Range(0, list1.Count / 2)
                          .Select(item => list1[item * 2] + list1[item * 2 + 1]).ToList<int>();
                }

                list1 = result;
                i++;                
            }
            return list1[0];
}
