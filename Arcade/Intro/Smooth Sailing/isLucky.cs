bool isLucky(int n) {
string str = n.ToString();
            if (str.Length % 2 == 0)
            {
                string str1 = str.Substring(0, str.Length / 2);
                string str2 = str.Substring(str.Length / 2);


                if (str1.Sum(c => int.Parse(new String(new char[] { c }))) ==
                    str2.Sum(c => int.Parse(new String(new char[] { c }))))
                { return true; }
            }
            return false;
}
