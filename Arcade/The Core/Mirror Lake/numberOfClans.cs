int numberOfClans(int[] divisors, int k) {
    List<int> clans = new List<int>(){1};
    for (int i = 2; i <= k; i++)
    {
        bool shouldAdd = true;
        foreach(int clan in clans) {
            if (isFriend(divisors, clan, i)) {
                shouldAdd = false;
                break;
            }
        }
        if (shouldAdd) {
            clans.Add(i);
        }
    }
    return clans.Count;
}
bool isFriend(int[] divisors, int a, int b) {
    for (int i = 0; i < divisors.Length; i++)
        if (!(a % divisors[i] == 0 && b % divisors[i] == 0)
                && !(a % divisors[i] != 0 && b % divisors[i] != 0))
            return false;
    return true;
}
