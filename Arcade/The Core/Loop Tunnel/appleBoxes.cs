int appleBoxes(int k) {
  int rApples = 0;
  int yApples = 0;
  for(int i = 1;i<=k;i++)
  {
    if(i%2==0)
    {
      rApples += (i*i);
    }
    else
    {
      yApples += (i*i);
    }
  }
  return (rApples-yApples);
}
