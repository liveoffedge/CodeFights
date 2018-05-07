int[] weakNumbers(int n) {
List<int> result=new List<int>();
    int weaknesses = 0, weaknest=0;
    for(int index=1;index<=n;index++) {
        int w = getWeakness(index);
        if(w>weaknest) {
            weaknest = w;
            weaknesses=1;
        }
        else if(w==weaknest)
            weaknesses++;
    }
    result.Add(weaknest);
    result.Add(weaknesses);
    return result.ToArray();
}
int getWeakness(int n) {
    int count=0;
    if(n==1)
        return 0;
    int dN = getD(n);
    for(int i=1;i<n;i++) {
        if(getD(i)>dN)
            count++;
    }
    return count;
}
int getD(int n) {
    if(n==1)
        return 1;
    if(n==2)
        return 2;
    int count=0;
    int halfN = n/2;
    for(int i=2;i<=halfN;i++) {
        if(n%i==0)
            count++;
    }
    return count+2;
}
