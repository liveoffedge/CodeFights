int electionsWinners(int[] votes, int k) {
var max = votes.Max();
    return k == 0 && votes.Where(d => d == votes.Max()).Count() == 1 ? 1 : votes.Count(t => t + k > max);
}
