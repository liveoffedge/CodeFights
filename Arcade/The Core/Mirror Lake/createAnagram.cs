int createAnagram(string s, string t) {
int[] cnt1 = new int[26];
    int[] cnt2 = new int[26];
    for (int i = 0; i < s.Length; i++) {
        cnt1[s[i] - 'A']++;
        cnt2[t[i] - 'A']++;
    }
 
    int ans = 0;
    for (int i = 0; i < 26; i++) {
        ans += Math.Abs(cnt1[i] - cnt2[i]);
    }
 
    return ans / 2;
}
