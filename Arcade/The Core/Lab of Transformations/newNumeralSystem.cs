string[] newNumeralSystem(char number) {
List<string> result = new List<string>();
    if(48<=number&&number<=57) {
        int n = int.Parse(""+number);
        for(int i=0;i<=n/2;i++) {
            result.Add(i.ToString()+" + "+(n-i).ToString());
        }
        return result.ToArray();
    }else if(65<=number&&number<=91){
        int n = int.Parse(""+(number-65));
        for(int i=0;i<=n/2;i++) {
            result.Add((char)(65+i)+" + "+(char)(65+n-i));
        }
        return result.ToArray();
    }
    else
        throw new ArgumentOutOfRangeException();
}
