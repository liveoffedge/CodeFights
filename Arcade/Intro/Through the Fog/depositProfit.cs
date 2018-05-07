int depositProfit(int deposit, int rate, int threshold) {
return Convert.ToInt32(Math.Ceiling(Math.Log(Convert.ToDouble(threshold) / Convert.ToDouble(deposit), 1 + Convert.ToDouble(rate) / 100)));
}
