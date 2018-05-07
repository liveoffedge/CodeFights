bool pairOfShoes(int[][] shoes) {
List<int> shoes1=new List<int>();
    List<int> shoes2=new List<int>();
    foreach(int[] shoe in shoes) {
        int type = shoe[0], size = shoe[1];
        if(type == 0) {
            shoes1.Add(size);
        } else {
            shoes2.Add(size);
        }
    }
    shoes1.Sort();
    shoes2.Sort();
    if(shoes1.Count != shoes2.Count) {
        return false;
    }
    for(int i=0; i<shoes1.Count;i++) {
        if(shoes1[i] != shoes2[i]) {
            return false;
        }
    }
    return true;
}
