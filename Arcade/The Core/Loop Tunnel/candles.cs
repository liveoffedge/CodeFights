int candles(int candlesNumber, int makeNew) {
     int bCount = candlesNumber;
            while (true)
            {
                int leftover = (candlesNumber - makeNew);                
                if (candlesNumber < makeNew)
                { 
                    break;
                }
                else
                {
                    candlesNumber = leftover + 1;
                     bCount++;
                }
                
            }
            return bCount;
}
