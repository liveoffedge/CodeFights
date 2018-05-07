int mostFrequentDigitSum(int n) {
 List<int> nums = new List<int>();
            //nums.Add(n);
            int num1 = n;

            while (num1 != 0)
            {
                int num2 = num1;
                int r;
                int sum = 0;
                while (num2 != 0)
                {
                    r = num2 % 10;
                    num2 = num2 / 10;
                    sum = sum + r;
                }

                nums.Add(sum);
                num1 = num1 - sum;
                if (num1 <= 0)
                {
                    num1 = 0;
                }

            }
            var numberGroups = nums.GroupBy(i => i);
            int iii = 0;
            int result = 0;
            foreach (var grp in numberGroups)
            {
                var number = grp.Key;
                var total = grp.Count();

                if (iii < total)
                {
                    iii = total;
                    result = number;
                }
                else
                {
                    if (iii == total)
                    {
                        if (result < number)
                        {
                            result = number;
                        }
                    }
                }

            }

            return result;
}
