bool areSimilar(int[] A, int[] B) {
    List<int>b=new List<int>(B);
    List<int>a=new List<int>(A);
    bool isSwapped=false;
    if(A.Length>=3 && A.Length<=100000 &&
      A.Length==B.Length) {        
        for(int i=0;i<A.Length;i++) {
            int aI =A[i];
            int bI =B[i];
             
            if(1<=aI && aI<=1000 &&
              1<=bI && bI<=1000) {
                int f = b.IndexOf(aI,i);
                if(f==i)
                    continue;
                else if(f>i) {
                    if(!isSwapped) {
                        int e = i;
                        while(e<a.Count) {
                            e=a.IndexOf(bI,e);
                            System.Console.WriteLine(e);
                            if(e<=i)
                                break;
                            if(b[e]==a[i])
                                break;
                            else
                                e++;
                        } 
                         
                        if(e>i && e<b.Count) {
                            b[e]=b[i];
                            isSwapped=true;
                        }
                        else
                            return false;    
                    }
                    else
                        return false;    
                }
                else
                    return false;
            }
            else
                throw new ArgumentOutOfRangeException();
        }
        return true;
    }
    else
        throw new ArgumentOutOfRangeException();
          
}
