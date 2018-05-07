int additionWithoutCarrying(int param1, int param2) {
    int result = 0;
            List<int> firstNum = new List<int>();
            List<int> secondNum = new List<int>();
            int temp1 = param1;
            while (temp1 != 0)
            {
                firstNum.Add(temp1 % 10);
                temp1 = temp1 / 10;
            }
            int temp2 = param2;
            while (temp2 != 0)
            {
                secondNum.Add(temp2 % 10);
                temp2 = temp2 / 10;
            }
            List<int> res = new List<int>();
            if (firstNum.Count > secondNum.Count)
            {
                for (int i = 0; i < firstNum.Count; i++)
                {
                    res.Add((firstNum[i] + (secondNum.Count > i ? secondNum[i] : 0)) % 10);
                }
            }
            else
            {
                for (int i = 0; i < secondNum.Count; i++)
                {
                    res.Add((secondNum[i] + (firstNum.Count > i ? firstNum[i] : 0)) % 10);
                }
            }
            for (int i = res.Count - 1; i >=0 ; i--)
            {
                result = result*10 + res[i];
            }
            return result;
}
