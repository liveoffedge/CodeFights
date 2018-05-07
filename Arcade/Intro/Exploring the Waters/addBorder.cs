string[] addBorder(string[] picture) {
List<string> result = new List<string>();
            int maxLen = 0;
            for (int i = 0; i < picture.Length; i++)
            {
                result.Add("*" + picture[i] + "*");
                if (maxLen < picture[i].Length)
                {
                    maxLen = picture[i].Length;
                }
            }

            string str = "";
            for (int i = 0; i < maxLen + 2; i++)
            {
                str = str + "*";
            }
            result.Add(str);
            result.Insert(0, str);
            return result.ToArray();
}
