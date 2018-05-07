int electionsWinners(int[] votes, int k) {
 int ma = 0;
    for (int i = 0; i < votes.Length; i++)
        ma = Math.Max(ma, votes[i]);
    int cnt = 0;
    for (int i = 0; i < votes.Length; i++)
        if (votes[i] + k > ma)
            cnt++;
    if (cnt == 0) {
        for (int i = 0; i < votes.Length; i++)
            if (votes[i] == ma)
                cnt++;
        if (cnt > 1)
            cnt = 0;
    }
    return cnt;
}
