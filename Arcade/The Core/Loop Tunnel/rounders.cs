int rounders(int value) {
  int result = value;
  var numbers = new List<int>();
  for (; result > 0; result /= 10)
  {
    numbers.Add(result % 10);
  }
  string str = "";
  for (int i = 0; i < numbers.Count-1; i++)
  {
    if (numbers[i] > 4)
    {
      numbers[i + 1]++;
      numbers[i] = 0;
    }
    else
    {
      numbers[i] = 0;
    }
  }
  for (int i = numbers.Count -1 ; i >= 0; i--)
  {
    str += numbers[i].ToString();
  }
  return Convert.ToInt32(str);
}
