int[] houseOfCats(int legs) {
List<int> people = new List<int>();
    int p=0;
    while(legs>=0) {
        int c=0;
        if(legs%4==2 ||legs%4==0) {
            if ((legs%4) == 2)
                c = 1;
            else
                c = 0;
        }
        people.Add(p+c);
        p+=2;
        legs-=4;
    }
    return people.ToArray();
}
