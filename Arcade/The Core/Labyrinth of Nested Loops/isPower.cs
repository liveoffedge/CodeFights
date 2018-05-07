bool isPower(int n) {
if(n==1)
        return true;
    for(int index=2;index<=Math.Sqrt(n);index++) {
        for(int power=2;power<=Math.Sqrt(n);power++) {
            if(Math.Pow(index,power)==n)
                return true;
        }
    }
    return false;
}
