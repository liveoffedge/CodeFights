int arrayMaxConsecutiveSum(int[] inputArray, int k)
        {
            if (inputArray.Length < 3 || inputArray.Length > Math.Pow(10, 5) + 1)
            {
                throw new ArgumentOutOfRangeException("inputArray");
            }

            if (k < 1 || k > inputArray.Length)
            {
                throw new ArgumentOutOfRangeException("k");
            }

            if (inputArray.Any(i => i < 1 || i > 1000))
            {
                throw new ArgumentOutOfRangeException("elements of inputArray");
            }

            
            var max = 0;
            var rem = 0;
            for (var i = 0; i <= inputArray.Length - k; i++)
            {
                if (i == 0)
                    rem = inputArray.Where((i1, i2) => i2 >= i && i2 < i + k).Sum();
                else
                    rem = rem + inputArray[i + k - 1] - inputArray[i - 1];

                max = Math.Max(rem, max);
            }

            return max;
        }
