bool palindromeRearranging(string inputString) {
char[] disChars = inputString.Distinct().ToArray();
            if (inputString.Length % 2 == 0)
            {                
                for (int i = 0; i < disChars.Length; i++)
                {
                    if (inputString.Count(f => f == disChars[i]) % 2 != 0)
                    {
                        return false;
                    }
                }
                return true;
                                
            }
            else
            {                
                int count = 0;
                for (int i = 0; i < disChars.Length; i++)
                {
                    if (inputString.Count(f => f == disChars[i]) % 2 != 0)
                    {
                        count++;
                    }
                }
                if (count == 1)
                {
                    return true;
                }
                return false;
            }  
}
