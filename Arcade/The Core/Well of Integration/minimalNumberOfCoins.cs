int minimalNumberOfCoins(int[] coins, int price) {
  int r = 0;
    int l=coins.Length-1;
    while(price>0) {
        while(price<coins[l]) {
            l-=1;
            if(l<0)
                break;
        }
        price -= coins[l];
        r+=1;
    }
    return r;
}
