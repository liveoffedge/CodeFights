string reverseParentheses(string s) {
string result = s;
            int lastpos = 0;

            while (true)
            {
                int ii = result.IndexOf('(');
                if (ii == -1)
                {
                    break;
                }
                for (int i = 0; i < result.Length; i++)
                {
                    if (result[i] == '(')
                    {
                        lastpos = i;
                    }

                    if (result[i] == ')')
                    {
                        string str = Reverse(result.Substring(lastpos + 1, i - lastpos - 1));
                        result = result.Substring(0, lastpos) + str + result.Substring(i + 1);
                        break;
                    }
                }
            }
            return result;
}

 public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
