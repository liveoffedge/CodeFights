bool beautifulText(string inputString, int l, int r) { 
   for (int i = l; i <= r; i++)
            {
               if (inputString.Length % i == (inputString.Length / i - 1))
                {
                   bool isSpace = true;
                   int j = (inputString.Length - i + 1) / i;
                   for (int k = 1; k <= j; k++)
                    {
                       if (inputString.Length >= (k * (i + 1)))
                        {
                           isSpace = isSpace && inputString[k * (i + 1) - 1] == ' ';
                        }
                    }
                   if (isSpace)
                       return isSpace;
                }
            }            
            var strArr = inputString.Split(' ');
            var lenList = (strArr.Select(i => i.Length).Distinct()).ToList();
            if (lenList.Count == 1)
            {
                var itemLen = lenList[0];
                if (itemLen >= l && itemLen <= r)
                {
                    return true;
                }
            }
            return false;
}
