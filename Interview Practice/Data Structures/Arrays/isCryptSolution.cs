bool isCryptSolution(string[] crypt, char[][] solution) {
 Dictionary<char, char> map = new Dictionary<char, char>();
            for (int i = 0; i < solution.Length; i++)
            {
                map.Add(solution[i][0], solution[i][1]);
            }
            List<String> list = new List<string>();
            foreach(String str in crypt)
            {
                if (map[str[0]] == '0' && str.Length > 1) return false;

                StringBuilder s = new StringBuilder();
                foreach(char c in str)
                {
                    s.Append(map[c] + "");
                }
                list.Add(s.ToString());
            }            
            double num1 = Double.Parse(list[0]);
            double num2 = Double.Parse(list[1]);
            double num3 = Double.Parse(list[2]);
            if (num1 + num2 == num3) return true;
            return false;
}
